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
		[Cpp2IlInjected.Address(RVA = "0x60219E0", Offset = "0x60205E0", VA = "0x1860219E0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles HLABNIGHLFE, float HAPBLBEJGGH, Vector3 BBEHPKKOBDE, Quaternion IDIJNBAPGMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x60217E0", Offset = "0x60203E0", VA = "0x1860217E0")]
		public void SetDamageValue(float HAPBLBEJGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6021BA0", Offset = "0x60207A0", VA = "0x186021BA0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MNPCGBKOFPE<T> : global::GANDAICPPHN<T>, CKHAEIDHOPE, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EBIJEFEBMKP<T> : CKHAEIDHOPE, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IMKNLFBDBON
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OPDCFNKIMNF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class EHHABKDMGLN<T> : global::NMCHCEAGLKO<T>, global::MNPCGBKOFPE<T>, global::GANDAICPPHN<T>, CKHAEIDHOPE, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BBMBBPELMIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public EHHABKDMGLN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
			public BBMBBPELMIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3690640", Offset = "0x368F240", VA = "0x183690640")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3690740", Offset = "0x368F340", VA = "0x183690740")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::IKLFCLDFOJM<T> IAIABINHGKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool EBGMODCAFHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T JBMLNCPMHCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool JIGLPOGPBPP;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x23848B0", Offset = "0x23834B0", VA = "0x1823848B0")]
		public EHHABKDMGLN(global::IKLFCLDFOJM<T> IAIABINHGKA, ObjectPool EBGMODCAFHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2384770", Offset = "0x2383370", VA = "0x182384770", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class KCODJDNIALM<T> : OBDOOKDFCDE, global::EBIJEFEBMKP<T>, CKHAEIDHOPE, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class MLJJPBOMECD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public KCODJDNIALM<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
			public MLJJPBOMECD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x3D9DC90", Offset = "0x3D9C890", VA = "0x183D9DC90")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x19BA3C0", Offset = "0x19B8FC0", VA = "0x1819BA3C0")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private global::IKLFCLDFOJM<T> IAIABINHGKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool JIGLPOGPBPP;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2CF30C0", Offset = "0x2CF1CC0", VA = "0x182CF30C0")]
		public KCODJDNIALM(global::IKLFCLDFOJM<T> IAIABINHGKA, ObjectPool EBGMODCAFHP, int INDBIEFHBOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2CF3070", Offset = "0x2CF1C70", VA = "0x182CF3070", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JIEPKLMIAHI<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public OPDCFNKIMNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::NMCHCEAGLKO<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::IKLFCLDFOJM<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		public JIEPKLMIAHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x31E26A0", Offset = "0x31E12A0", VA = "0x1831E26A0")]
		internal void <Exists>b__0(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x31E2740", Offset = "0x31E1340", VA = "0x1831E2740")]
		internal void <Exists>b__1(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x31E27A0", Offset = "0x31E13A0", VA = "0x1831E27A0")]
		internal void <Exists>b__2()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<IMKNLFBDBON> CABAFAINIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private NFPEFJAAEJK GPHNBLBAAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool EBGMODCAFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool JIGLPOGPBPP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool FDDEPHKGKKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60207B0", Offset = "0x601F3B0", VA = "0x1860207B0")]
	private static void EFLHHLOCBHJ(Component CNBPNBOALAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6020BC0", Offset = "0x601F7C0", VA = "0x186020BC0")]
	public OPDCFNKIMNF(string MCFOLFGBLFL, int MKOGGBIJMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2A08720", Offset = "0x2A07320", VA = "0x182A08720")]
	public global::MNPCGBKOFPE<T> DAHCFDBKLKE<T>(AssetReference EGIKIEJBFFC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2A087B0", Offset = "0x2A073B0", VA = "0x182A087B0")]
	public global::EBIJEFEBMKP<T> DNJEHEGNALC<T>(AssetReference EGIKIEJBFFC, int GGKDNLHEHMD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2A08860", Offset = "0x2A07460", VA = "0x182A08860")]
	public global::GANDAICPPHN<bool> MKAKFEIOKNJ<T>(AssetReference EGIKIEJBFFC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60206A0", Offset = "0x601F2A0", VA = "0x1860206A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6020A00", Offset = "0x601F600", VA = "0x186020A00")]
	private void GGJPJNHCIEB(UnityEngine.Object FFOEBAHAIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6020510", Offset = "0x601F110", VA = "0x186020510")]
	private ObjectPool BIGHNKGOAOH(string MCFOLFGBLFL)
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
		private static GlobalPool OBHHJPCPMOB;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject MDNGJECALOJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool OHEGMANNBEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x601F290", Offset = "0x601DE90", VA = "0x18601F290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3745920", Offset = "0x3744520", VA = "0x183745920")]
		public static void SafeRelease<T>(T AOEMDAGAALP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x601F190", Offset = "0x601DD90", VA = "0x18601F190")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x601F280", Offset = "0x601DE80", VA = "0x18601F280")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, ICAMHKGGOBH> GENFIFJKHIJ;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2A09C90", Offset = "0x2A08890", VA = "0x182A09C90")]
		public T Acquire<T>(T HLABNIGHLFE, [Optional] Action<Component> DBIFJNOOFPK) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2A0A020", Offset = "0x2A08C20", VA = "0x182A0A020")]
		public bool Release<T>(T AOEMDAGAALP) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2A09FC0", Offset = "0x2A08BC0", VA = "0x182A09FC0")]
		public void Prefill<T>(T HLABNIGHLFE, int LIFIOIMKBFA, [Optional] Action<Component> BBFNLLCPOMK) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2A09DD0", Offset = "0x2A089D0", VA = "0x182A09DD0")]
		public bool Exists<T>(T HLABNIGHLFE) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2A09D20", Offset = "0x2A08920", VA = "0x182A09D20")]
		public void Clear<T>(T HLABNIGHLFE) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6021230", Offset = "0x601FE30", VA = "0x186021230")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2A09E80", Offset = "0x2A08A80", VA = "0x182A09E80")]
		private ICAMHKGGOBH PNDNGICPMHK<T>(T HLABNIGHLFE) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		public void TrackInstantiation(string FHMAJAOHFCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		public void EnableStats(bool DPOFEDNHPMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6021380", Offset = "0x601FF80", VA = "0x186021380")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class ICAMHKGGOBH
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface KGGEIJFJALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EJBNDNJOLLN(bool EMKILHIJCOI);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract Component LECHBNBCLCP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract string JBHHONFDCDB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int EGONDAAPPIC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void DNJEHEGNALC(int GGKDNLHEHMD, Action<Component> BBFNLLCPOMK);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Component DAHCFDBKLKE(Action<Component> DBIFJNOOFPK);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool MCMCELGEBEK(Component HFNAEFAFGBI);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void GGNFLDPHLOD();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x601FB30", Offset = "0x601E730", VA = "0x18601FB30")]
	protected void DBGCKIDOPOF(Component AOEMDAGAALP, bool EMKILHIJCOI, bool NJMIPNLKHIK, bool GHDGKPNCKMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x601FCB0", Offset = "0x601E8B0", VA = "0x18601FCB0")]
	protected void KIMLHIDNAPI(Transform GKIPGHENNKA, bool EMKILHIJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	protected ICAMHKGGOBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LFHOCJMBGFC<T> : ICAMHKGGOBH where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T HLABNIGHLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool GHJKIBCEBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool NJMIPNLKHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> OBBCLJKFNAP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Component LECHBNBCLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override string JBHHONFDCDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2C46C20", Offset = "0x2C45820", VA = "0x182C46C20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override int EGONDAAPPIC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2C46520", Offset = "0x2C45120", VA = "0x182C46520", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2C46DD0", Offset = "0x2C459D0", VA = "0x182C46DD0")]
	public LFHOCJMBGFC(T HLABNIGHLFE, ObjectPool GHJKIBCEBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2C467C0", Offset = "0x2C453C0", VA = "0x182C467C0", Slot = "7")]
	public override void DNJEHEGNALC(int GGKDNLHEHMD, Action<Component> DBIFJNOOFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2C46550", Offset = "0x2C45150", VA = "0x182C46550", Slot = "8")]
	public override Component DAHCFDBKLKE(Action<Component> DBIFJNOOFPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2C46C40", Offset = "0x2C45840", VA = "0x182C46C40", Slot = "9")]
	public override bool MCMCELGEBEK(Component HFNAEFAFGBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2C468D0", Offset = "0x2C454D0", VA = "0x182C468D0", Slot = "10")]
	public override void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2C46AC0", Offset = "0x2C456C0", VA = "0x182C46AC0")]
	private T HNHHCFEJNJA()
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
		public interface PMOAIBKKMGF
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			GameObject GBDDNDOCCIO
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6020E60", Offset = "0x601FA60", VA = "0x186020E60")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x60211B0", Offset = "0x601FDB0", VA = "0x1860211B0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool OBHHJPCPMOB;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject MDNGJECALOJ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static PersistentGlobalPool OHEGMANNBEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x60215F0", Offset = "0x60201F0", VA = "0x1860215F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6021500", Offset = "0x6020100", VA = "0x186021500")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x601F280", Offset = "0x601DE80", VA = "0x18601F280")]
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
		public ICAMHKGGOBH PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KFCAOKPKANE
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int MILJFMLGNGH(PooledParticle.PBGDFKDCDBH FBPLEGGBHNP);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum AKPLMPICJJF
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
		public enum PBGDFKDCDBH
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
		public interface IKOCGIIJBCC
		{
			[Cpp2IlInjected.Token(Token = "0x17000015")]
			bool MLMAODHOKCA
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			Vector3 LLDONAGLBGM
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			Camera FJNIEFKCCFF
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
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

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1355460", Offset = "0x1354060", VA = "0x181355460")]
			public ColorConfiguration(ParticleSystem NGHCGKOPGDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x601EFA0", Offset = "0x601DBA0", VA = "0x18601EFA0")]
			public void GKLIJKNKJIK(Color NCBJACAKLIH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class OHGJAIFKNIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public OHGJAIFKNIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x60204E0", Offset = "0x601F0E0", VA = "0x1860204E0")]
			internal void <SetRenderingEnabled>b__0(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class HKCDNOKLIFK : IEnumerator<FEPBFCLHFNJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private FEPBFCLHFNJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private IKOCGIIJBCC <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private FEPBFCLHFNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x737640", Offset = "0x736240", VA = "0x180737640")]
			[DebuggerHidden]
			public HKCDNOKLIFK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x601F450", Offset = "0x601E050", VA = "0x18601F450", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x601FAF0", Offset = "0x601E6F0", VA = "0x18601FAF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class PEFGJKEHHMD : IEnumerator<FEPBFCLHFNJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private FEPBFCLHFNJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private FEPBFCLHFNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x737640", Offset = "0x736240", VA = "0x180737640")]
			[DebuggerHidden]
			public PEFGJKEHHMD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6021400", Offset = "0x6020000", VA = "0x186021400", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x60214C0", Offset = "0x60200C0", VA = "0x1860214C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> IAIHNPBPLOF;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<KFCAOKPKANE> MMEEFKPCJEM;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> PMBMDNJAOOE;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static GMBEEMHKFHH NJADEELJLIF;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float OEDOHAGDJDI = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool GPMBKBHBDJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int BAKBJPOINGG;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private PBGDFKDCDBH category;

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
		private ParticleSystem.MinMaxGradient[] FIIEHOAFODB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool PCIINHHEKJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float GPNOBDLOBLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float HDCELLOMPIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform LEEDBANNKGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 FJMEPHDDECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 DPEMGLPBDDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private AKPLMPICJJF JOHHBMHINAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private GMBEEMHKFHH CELJGJNPEEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool GDCELBIBFFP;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static IEnumerable<PooledParticle> CAKNPNEHAAK
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6025490", Offset = "0x6024090", VA = "0x186025490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public PBGDFKDCDBH ADBHHEEOBJN
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x749E50", Offset = "0x748A50", VA = "0x180749E50")]
			get
			{
				return default(PBGDFKDCDBH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int NFIAIACEAMD
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6B7080", Offset = "0x6B5C80", VA = "0x1806B7080")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool CBCJINGKOAH
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6025180", Offset = "0x6023D80", VA = "0x186025180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static int GFHKCMHMBEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6025310", Offset = "0x6023F10", VA = "0x186025310")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected static bool GMFDOEAPNKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6023660", Offset = "0x6022260", VA = "0x186023660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ParticleSystem ELNFBIECBIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6982D0", Offset = "0x696ED0", VA = "0x1806982D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x766940", Offset = "0x765540", VA = "0x180766940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ParticleSystem[] EOIFBJOJFME
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6B6560", Offset = "0x6B5160", VA = "0x1806B6560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7070C0", Offset = "0x705CC0", VA = "0x1807070C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private ParticleSystemRenderer[] DLBLLHHHJOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x694E70", Offset = "0x693A70", VA = "0x180694E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x695830", Offset = "0x694430", VA = "0x180695830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private AKPLMPICJJF CCIFPCCDBDG
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x706E80", Offset = "0x705A80", VA = "0x180706E80")]
			get
			{
				return default(AKPLMPICJJF);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6021FF0", Offset = "0x6020BF0", VA = "0x186021FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action GJGCMOGPMEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x60250E0", Offset = "0x6023CE0", VA = "0x1860250E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x60254F0", Offset = "0x60240F0", VA = "0x1860254F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6024C80", Offset = "0x6023880", VA = "0x186024C80")]
		public static PooledParticle TryPlayPrefab(PooledParticle HLABNIGHLFE, Vector3 BBEHPKKOBDE, Quaternion IDIJNBAPGMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6024A90", Offset = "0x6023690", VA = "0x186024A90")]
		public static PooledParticle TryPlayPrefab(PooledParticle HLABNIGHLFE, Vector3 BBEHPKKOBDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6024100", Offset = "0x6022D00", VA = "0x186024100")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6022110", Offset = "0x6020D10", VA = "0x186022110")]
		private void FBPPMHAIDIG(bool DDGFCAEOBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x60220C0", Offset = "0x6020CC0", VA = "0x1860220C0")]
		[IteratorStateMachine(typeof(HKCDNOKLIFK))]
		private static IEnumerator<FEPBFCLHFNJ> DIBMFKFMPPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6022B10", Offset = "0x6021710", VA = "0x186022B10")]
		private static void MCNBADHIIAK(Stopwatch KIACJFINHDJ, Vector3 AEINIBALDME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6022010", Offset = "0x6020C10", VA = "0x186022010")]
		private static int COKOHKGIDMM(PooledParticle NEDFKMIBIEI, PooledParticle FMLJLFCAJGB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6022EA0", Offset = "0x6021AA0", VA = "0x186022EA0")]
		private static int MILJFMLGNGH(PBGDFKDCDBH FBPLEGGBHNP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x60224C0", Offset = "0x60210C0", VA = "0x1860224C0")]
		protected void LNNIEABMEDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6022FB0", Offset = "0x6021BB0", VA = "0x186022FB0")]
		protected void NBNGCHKNEIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6021C40", Offset = "0x6020840", VA = "0x186021C40", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x60226C0", Offset = "0x60212C0", VA = "0x1860226C0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x60235E0", Offset = "0x60221E0", VA = "0x1860235E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6023560", Offset = "0x6022160", VA = "0x186023560")]
		[IteratorStateMachine(typeof(PEFGJKEHHMD))]
		private IEnumerator<FEPBFCLHFNJ> NKMKAPCHKNM(float FNJNHCECBOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6022960", Offset = "0x6021560", VA = "0x186022960")]
		private void MCMCELGEBEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x60248A0", Offset = "0x60234A0", VA = "0x1860248A0")]
		public void SetDuration(float FNJNHCECBOJ, bool JKGAHMILNOP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6023DE0", Offset = "0x60229E0", VA = "0x186023DE0")]
		public void Play(Transform BDFNPICELLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x60237C0", Offset = "0x60223C0", VA = "0x1860237C0")]
		public void Play(Transform BDFNPICELLL, bool APFLCCOIIEH, float LIOKNMBFMHJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6023910", Offset = "0x6022510", VA = "0x186023910")]
		public void Play(Transform BDFNPICELLL, Vector3 DPEMGLPBDDM, bool APFLCCOIIEH, float LIOKNMBFMHJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6023B90", Offset = "0x6022790", VA = "0x186023B90")]
		public void Play(Transform PPEAHCCGACF, Quaternion IDIJNBAPGMK, bool APFLCCOIIEH = false, float LIOKNMBFMHJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6023A60", Offset = "0x6022660", VA = "0x186023A60")]
		public void Play(Transform PPEAHCCGACF, Vector3 DPEMGLPBDDM, Quaternion IDIJNBAPGMK, bool APFLCCOIIEH = false, float LIOKNMBFMHJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x60236F0", Offset = "0x60222F0", VA = "0x1860236F0")]
		public void Play(Vector3 BBEHPKKOBDE, Quaternion IDIJNBAPGMK, Vector3 NPDJDHDPINH, bool APFLCCOIIEH = false, float LIOKNMBFMHJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6023F20", Offset = "0x6022B20", VA = "0x186023F20")]
		public void Play(Vector3 BBEHPKKOBDE, Quaternion IDIJNBAPGMK, bool APFLCCOIIEH = false, float LIOKNMBFMHJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6023CD0", Offset = "0x60228D0", VA = "0x186023CD0")]
		public void Play(bool APFLCCOIIEH = false, float LIOKNMBFMHJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6024A00", Offset = "0x6023600", VA = "0x186024A00")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6024970", Offset = "0x6023570", VA = "0x186024970")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6022330", Offset = "0x6020F30", VA = "0x186022330")]
		private void KMGGLBFODFJ(float FNJNHCECBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6021E80", Offset = "0x6020A80", VA = "0x186021E80")]
		private void BOMPBJCAFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6023FE0", Offset = "0x6022BE0", VA = "0x186023FE0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x60242A0", Offset = "0x6022EA0", VA = "0x1860242A0")]
		public void SetColor(Color NCBJACAKLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x60221F0", Offset = "0x6020DF0", VA = "0x1860221F0")]
		private void KIKCAONPNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6025080", Offset = "0x6023C80", VA = "0x186025080")]
		public PooledParticle()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JKMMEKILHLE
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static byte[] AGGHFJMNIJN;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static int BFFGPOMCPJB;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static int MBPNPBCPPJJ;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static BigInteger ELICCIFCIHI;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public JKMMEKILHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x601FEB0", Offset = "0x601EAB0", VA = "0x18601FEB0")]
	private static string HIPMGELGEMF(byte[] APLKEMLCGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x601FFC0", Offset = "0x601EBC0", VA = "0x18601FFC0")]
	public static string OIADEFGOGFH(byte[] FCLGIGIIKEH, bool ABEBLNADKAB)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
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
