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
		[Cpp2IlInjected.Address(RVA = "0x80E17A0", Offset = "0x80E01A0", VA = "0x1880E17A0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles ANGPMLNFAIK, float IMFBIDLPPFJ, Vector3 JFMEMBGKAOB, Quaternion NGPACIMGGNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x80E1440", Offset = "0x80DFE40", VA = "0x1880E1440")]
		public void SetDamageValue(float IMFBIDLPPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x80E18E0", Offset = "0x80E02E0", VA = "0x1880E18E0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LFMHCAMEPFJ<T> : MPBOGDMHBIL<T>, FDBBAHKKNBB, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NCHEFGOEIKG<T> : FDBBAHKKNBB, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KHKBEKPMECN
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FGNPHACJEDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NOPELJJJDNG<T> : KCIAFHBPEDF<T>, LFMHCAMEPFJ<T>, MPBOGDMHBIL<T>, FDBBAHKKNBB, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JIEFGDFHOFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public NOPELJJJDNG<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public JIEFGDFHOFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x509CAE0", Offset = "0x509B4E0", VA = "0x18509CAE0")]
			internal void HKNPEBJEBAB(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3ECB110", Offset = "0x3EC9B10", VA = "0x183ECB110")]
			internal void OKHOIGIFEDD(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ODDHNIEMFCD<T> LMOJGEDGJOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool LGOCKJJFPCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T NMGHOHCNINO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool KJMPONALMPD;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5554AA0", Offset = "0x55534A0", VA = "0x185554AA0")]
		public NOPELJJJDNG(ODDHNIEMFCD<T> LMOJGEDGJOE, ObjectPool LGOCKJJFPCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5554960", Offset = "0x5553360", VA = "0x185554960", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class JELEGINJOGK<T> : NPBFAPINKBN, NCHEFGOEIKG<T>, FDBBAHKKNBB, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class JIFDHNGNHOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public JELEGINJOGK<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public JIFDHNGNHOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x509CBF0", Offset = "0x509B5F0", VA = "0x18509CBF0")]
			internal void HKNPEBJEBAB(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x157AF80", Offset = "0x1579980", VA = "0x18157AF80")]
			internal void OKHOIGIFEDD(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private ODDHNIEMFCD<T> LMOJGEDGJOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool KJMPONALMPD;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x50563C0", Offset = "0x5054DC0", VA = "0x1850563C0")]
		public JELEGINJOGK(ODDHNIEMFCD<T> LMOJGEDGJOE, ObjectPool LGOCKJJFPCI, int EKHMKELJPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5056360", Offset = "0x5054D60", VA = "0x185056360", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GOABIJNIDBA<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public FGNPHACJEDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public KCIAFHBPEDF<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public ODDHNIEMFCD<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public GOABIJNIDBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4C8BCC0", Offset = "0x4C8A6C0", VA = "0x184C8BCC0")]
		internal void BBGGLGPMCIF(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4C8BD60", Offset = "0x4C8A760", VA = "0x184C8BD60")]
		internal void FPDPJNNBPIP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4C8BDC0", Offset = "0x4C8A7C0", VA = "0x184C8BDC0")]
		internal void KONCAAFDPAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<KHKBEKPMECN> CHCOCBNHLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private AMHJDGNPIEH EPMLAMOGEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool LGOCKJJFPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool KJMPONALMPD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x80DF600", Offset = "0x80DE000", VA = "0x1880DF600")]
	private static void BDICPKGCEJI(Component FDMBFEDKLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x80DFCA0", Offset = "0x80DE6A0", VA = "0x1880DFCA0")]
	public FGNPHACJEDI(string DCBDCJILPIG, int DGODIAHENDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3A497D0", Offset = "0x3A481D0", VA = "0x183A497D0")]
	public LFMHCAMEPFJ<T> LPOPHENMMHM<T>(AssetReference ECNADIOLHFH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3A49320", Offset = "0x3A47D20", VA = "0x183A49320")]
	public NCHEFGOEIKG<T> BGEKLDIADNF<T>(AssetReference ECNADIOLHFH, int IMCIONKBBCL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3A493D0", Offset = "0x3A47DD0", VA = "0x183A493D0")]
	public MPBOGDMHBIL<bool> IAKPEOGICJH<T>(AssetReference ECNADIOLHFH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x80DF9D0", Offset = "0x80DE3D0", VA = "0x1880DF9D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x80DFAC0", Offset = "0x80DE4C0", VA = "0x1880DFAC0")]
	private void PAOHALKLJFK(UnityEngine.Object HDDNHECLPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x80DF840", Offset = "0x80DE240", VA = "0x1880DF840")]
	private ObjectPool COANDOMOOEA(string DCBDCJILPIG)
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
		private static GlobalPool IAPMLBGOKMC;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject AOBMBCEEOGJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool FDCAMNOGINK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x80E0000", Offset = "0x80DEA00", VA = "0x1880E0000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3A7A570", Offset = "0x3A78F70", VA = "0x183A7A570")]
		public static void SafeRelease<T>(T OJDHMKOBKLD) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x80DFF30", Offset = "0x80DE930", VA = "0x1880DFF30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x80DFFF0", Offset = "0x80DE9F0", VA = "0x1880DFFF0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, OJHGNHGFLCL> ENMFGNOMMLD;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3C029D0", Offset = "0x3C013D0", VA = "0x183C029D0")]
		public T Acquire<T>(T ANGPMLNFAIK, [Optional] Action<Component> LIEOOIIDEGK) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3C02D40", Offset = "0x3C01740", VA = "0x183C02D40")]
		public bool Release<T>(T OJDHMKOBKLD) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3C02CF0", Offset = "0x3C016F0", VA = "0x183C02CF0")]
		public void Prefill<T>(T ANGPMLNFAIK, int CBCLCLJHDLF, [Optional] Action<Component> KCIGBMKODDP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3C02C50", Offset = "0x3C01650", VA = "0x183C02C50")]
		public bool Exists<T>(T ANGPMLNFAIK) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3C02BA0", Offset = "0x3C015A0", VA = "0x183C02BA0")]
		public void Clear<T>(T ANGPMLNFAIK) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x80E1000", Offset = "0x80DFA00", VA = "0x1880E1000")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3C02A60", Offset = "0x3C01460", VA = "0x183C02A60")]
		private OJHGNHGFLCL BDILPJPGOID<T>(T ANGPMLNFAIK) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public void TrackInstantiation(string LECELJPCELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public void EnableStats(bool BJFNIEFPBAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x80E1170", Offset = "0x80DFB70", VA = "0x1880E1170")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class OJHGNHGFLCL
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface CKAOICDAOMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IIJDOKIFGDC(bool JJAMIIBHPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string HMKINKIIOPK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int ILFFJNLBFBF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void BGEKLDIADNF(int IMCIONKBBCL, Action<Component> KCIGBMKODDP);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component LPOPHENMMHM(Action<Component> LIEOOIIDEGK);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool DKAGEAADPDL(Component EPOEHDLAHPC);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void MPMJEFEEPDP();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x80E0880", Offset = "0x80DF280", VA = "0x1880E0880")]
	protected void FKNFKMJCFPB(Component OJDHMKOBKLD, bool JJAMIIBHPKD, bool JOGBCHBDOHI, bool IGOOIKJCBPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x80E0A00", Offset = "0x80DF400", VA = "0x1880E0A00")]
	protected void PHJAIMHCKKL(Transform CBIHIEPBIEI, bool JJAMIIBHPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	protected OJHGNHGFLCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ELNLFNHGDKG<T> : OJHGNHGFLCL where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T ANGPMLNFAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool NEHAMCKKMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool JOGBCHBDOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> PAFFPPFEBBF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string HMKINKIIOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x46B27D0", Offset = "0x46B11D0", VA = "0x1846B27D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int ILFFJNLBFBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x46B3070", Offset = "0x46B1A70", VA = "0x1846B3070", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x46B30B0", Offset = "0x46B1AB0", VA = "0x1846B30B0")]
	public ELNLFNHGDKG(T ANGPMLNFAIK, ObjectPool NEHAMCKKMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x46B27F0", Offset = "0x46B11F0", VA = "0x1846B27F0", Slot = "6")]
	public override void BGEKLDIADNF(int IMCIONKBBCL, Action<Component> LIEOOIIDEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x46B2A80", Offset = "0x46B1480", VA = "0x1846B2A80", Slot = "7")]
	public override Component LPOPHENMMHM(Action<Component> LIEOOIIDEGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x46B28F0", Offset = "0x46B12F0", VA = "0x1846B28F0", Slot = "8")]
	public override bool DKAGEAADPDL(Component EPOEHDLAHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x46B2CE0", Offset = "0x46B16E0", VA = "0x1846B2CE0", Slot = "9")]
	public override void MPMJEFEEPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x46B2EC0", Offset = "0x46B18C0", VA = "0x1846B2EC0")]
	private T NMCLIEDBPEP()
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
		public interface BOEFDLEBCHC
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject IPCKBKAKDGC
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
		[Cpp2IlInjected.Address(RVA = "0x80E0C80", Offset = "0x80DF680", VA = "0x1880E0C80")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x80E0F70", Offset = "0x80DF970", VA = "0x1880E0F70")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool IAPMLBGOKMC;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject AOBMBCEEOGJ;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool FDCAMNOGINK
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x80E12C0", Offset = "0x80DFCC0", VA = "0x1880E12C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x80E1200", Offset = "0x80DFC00", VA = "0x1880E1200")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x80DFFF0", Offset = "0x80DE9F0", VA = "0x1880DFFF0")]
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
		public OJHGNHGFLCL PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IFJPKADDLOI
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int MLNMEIKNAPM(PooledParticle.KDFNODBFGBD KGIGFDOMMJA);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum DJHKEHACKDI
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
		public enum KDFNODBFGBD
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
		public interface EKLFJJKICPP
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool JNJLFOCMABD
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 CKGJFPKBOAJ
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera KNOGCAAGPLB
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
			[Cpp2IlInjected.Address(RVA = "0x6D067A0", Offset = "0x6D051A0", VA = "0x186D067A0")]
			public ColorConfiguration(ParticleSystem OJPDEJDJFGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x80DF3E0", Offset = "0x80DDDE0", VA = "0x1880DF3E0")]
			public void BHHJHBHEBKL(Color JJNDBAIEAAG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class EEEHBKOMNKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public EEEHBKOMNKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x80DF5D0", Offset = "0x80DDFD0", VA = "0x1880DF5D0")]
			internal void CAGBAPILGIN(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class KIKAKLEBIJG : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private HGOIDBIKHMF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private EKLFJJKICPP <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public KIKAKLEBIJG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x80E0150", Offset = "0x80DEB50", VA = "0x1880E0150", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x80E0770", Offset = "0x80DF170", VA = "0x1880E0770", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class MKJFHEGGAOA : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private HGOIDBIKHMF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public MKJFHEGGAOA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x80E07C0", Offset = "0x80DF1C0", VA = "0x1880E07C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x80E0830", Offset = "0x80DF230", VA = "0x1880E0830", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static bool OptimizeReleaseMonitoring;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> GGFPDLLLOAB;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Lazy<IFJPKADDLOI> JLDHILIPJCD;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static List<PooledParticle> POKNIFEEANH;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IDJIHHOMEIC EMHDNPFKOMM;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float BPAICNPBNMJ = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static bool IOHMOOLKNPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected int KIPJHNNGBEN;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private KDFNODBFGBD category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float? PMFFPNCBHGH;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private ParticleSystem.MinMaxGradient[] OIOGJCJHKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private ParticleSystem.MinMaxGradient[] PDFCFEHNDLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool LMMKONIIKGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private float NFGFPDHJIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private float CMLKLMLKICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Transform MBNHCDHACDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Vector3 LMACJCMEGLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Vector3 NHMIMNDFGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private DJHKEHACKDI KGJGFAIDPIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private IDJIHHOMEIC PLGKANHPMMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		protected bool OBHDNPFFKFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private Transform CMKLAJBMKMI;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> LDEPODOHMEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x80E5600", Offset = "0x80E4000", VA = "0x1880E5600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public KDFNODBFGBD GMBICOHDEJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA32DA0", Offset = "0xA317A0", VA = "0x180A32DA0")]
			get
			{
				return default(KDFNODBFGBD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int CADNONBEAKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA07C40", VA = "0x180A09240")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HIBBJOPICNA
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x80E5350", Offset = "0x80E3D50", VA = "0x1880E5350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int FBBEINLLEPH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x80E54C0", Offset = "0x80E3EC0", VA = "0x1880E54C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool IOCNJGACOJB
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x80E26A0", Offset = "0x80E10A0", VA = "0x1880E26A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem DNIIMKPMFPL
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA093C0", VA = "0x180A0A9C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] PFHLMEFIAEO
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA14650", Offset = "0xA13050", VA = "0x180A14650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] GEBFBFGJEOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA10D40", Offset = "0xA0F740", VA = "0x180A10D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private DJHKEHACKDI FDMMDHHFELG
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xE49120", Offset = "0xE47B20", VA = "0x180E49120")]
			get
			{
				return default(DJHKEHACKDI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x80E1C30", Offset = "0x80E0630", VA = "0x1880E1C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Transform MNINMACDPEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x80E5650", Offset = "0x80E4050", VA = "0x1880E5650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action CMMIDNNMCLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x80E52B0", Offset = "0x80E3CB0", VA = "0x1880E52B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x80E56A0", Offset = "0x80E40A0", VA = "0x1880E56A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x80E4CF0", Offset = "0x80E36F0", VA = "0x1880E4CF0")]
		public static PooledParticle TryPlayPrefab(PooledParticle ANGPMLNFAIK, Vector3 JFMEMBGKAOB, Quaternion NGPACIMGGNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x80E4E10", Offset = "0x80E3810", VA = "0x1880E4E10")]
		public static PooledParticle TryPlayPrefab(PooledParticle ANGPMLNFAIK, Vector3 JFMEMBGKAOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x80E4400", Offset = "0x80E2E00", VA = "0x1880E4400")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x80E2570", Offset = "0x80E0F70", VA = "0x1880E2570")]
		private void DPMCNNAOLEC(bool NDMOBAIGJOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x80E2640", Offset = "0x80E1040", VA = "0x1880E2640")]
		[IteratorStateMachine(typeof(KIKAKLEBIJG))]
		private static IEnumerator<HGOIDBIKHMF> ILMBDIIJJGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x80E32C0", Offset = "0x80E1CC0", VA = "0x1880E32C0")]
		private static void ONBMNCPPFHP(Stopwatch JNHNJKFGOJB, Vector3 DJEIANNOONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x80E2D60", Offset = "0x80E1760", VA = "0x1880E2D60")]
		private static int NOIIKDHNLED(PooledParticle LCMCGCNDGLJ, PooledParticle JAOCPECLJLL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x80E2C60", Offset = "0x80E1660", VA = "0x1880E2C60")]
		private static int MLNMEIKNAPM(KDFNODBFGBD KGIGFDOMMJA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x80E2FA0", Offset = "0x80E19A0", VA = "0x1880E2FA0")]
		protected void OCIIBIOICAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x80E1DA0", Offset = "0x80E07A0", VA = "0x1880E1DA0")]
		protected void CGGMBCBDJAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x80E19C0", Offset = "0x80E03C0", VA = "0x1880E19C0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x80E2930", Offset = "0x80E1330", VA = "0x1880E2930")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x80E3630", Offset = "0x80E2030", VA = "0x1880E3630")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x80E1C50", Offset = "0x80E0650", VA = "0x1880E1C50")]
		[IteratorStateMachine(typeof(MKJFHEGGAOA))]
		private IEnumerator<HGOIDBIKHMF> BHINFICBGGM(float IDDLOIFGNLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x80E2370", Offset = "0x80E0D70", VA = "0x1880E2370")]
		private void DKAGEAADPDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x80E4A30", Offset = "0x80E3430", VA = "0x1880E4A30")]
		public void SetDuration(float IDDLOIFGNLI, bool PDGHDIHBKDI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x80E3730", Offset = "0x80E2130", VA = "0x1880E3730")]
		public void Play(Transform ONAGDAJIMFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x80E3FD0", Offset = "0x80E29D0", VA = "0x1880E3FD0")]
		public void Play(Transform ONAGDAJIMFG, bool PBPLIEFLBJF, float AFCAIBCBKAF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x80E3880", Offset = "0x80E2280", VA = "0x1880E3880")]
		public void Play(Transform ONAGDAJIMFG, Vector3 NHMIMNDFGNE, bool PBPLIEFLBJF, float AFCAIBCBKAF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x80E39D0", Offset = "0x80E23D0", VA = "0x1880E39D0")]
		public void Play(Transform JOKEGIDPHKN, Quaternion NGPACIMGGNA, bool PBPLIEFLBJF = false, float AFCAIBCBKAF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x80E4140", Offset = "0x80E2B40", VA = "0x1880E4140")]
		public void Play(Transform JOKEGIDPHKN, Vector3 NHMIMNDFGNE, Quaternion NGPACIMGGNA, bool PBPLIEFLBJF = false, float AFCAIBCBKAF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x80E3C70", Offset = "0x80E2670", VA = "0x1880E3C70")]
		public void Play(Vector3 JFMEMBGKAOB, Quaternion NGPACIMGGNA, Vector3 CGGOJBPICAG, bool PBPLIEFLBJF = false, float AFCAIBCBKAF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x80E3B10", Offset = "0x80E2510", VA = "0x1880E3B10")]
		public void Play(Vector3 JFMEMBGKAOB, Quaternion NGPACIMGGNA, bool PBPLIEFLBJF = false, float AFCAIBCBKAF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x80E3DF0", Offset = "0x80E27F0", VA = "0x1880E3DF0")]
		public void Play(bool PBPLIEFLBJF = false, float AFCAIBCBKAF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x80E4C50", Offset = "0x80E3650", VA = "0x1880E4C50")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x80E4B00", Offset = "0x80E3500", VA = "0x1880E4B00")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x80E2E10", Offset = "0x80E1810", VA = "0x1880E2E10")]
		private void OCBHNKKEMNB(float IDDLOIFGNLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x80E2720", Offset = "0x80E1120", VA = "0x1880E2720")]
		private void LKNNMNBKMJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x80E4270", Offset = "0x80E2C70", VA = "0x1880E4270")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x80E4580", Offset = "0x80E2F80", VA = "0x1880E4580")]
		public void SetColor(Color JJNDBAIEAAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x80E1CE0", Offset = "0x80E06E0", VA = "0x1880E1CE0")]
		private void CEOFHOELKDF(float? FDFNAMJJMBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x80E36C0", Offset = "0x80E20C0", VA = "0x1880E36C0")]
		private void PMDKHNNMDJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x80E3190", Offset = "0x80E1B90", VA = "0x1880E3190")]
		private void OLOLMMHCFDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x80E5220", Offset = "0x80E3C20", VA = "0x1880E5220")]
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
