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
		[Cpp2IlInjected.Address(RVA = "0x1DC1680", Offset = "0x1DC0080", VA = "0x181DC1680")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles INOMEBNKFPO, float MGPEFBCIIDO, Vector3 LHCEFCJDGIJ, Quaternion FDBNIAOOEMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1DC1480", Offset = "0x1DBFE80", VA = "0x181DC1480")]
		public void SetDamageValue(float MGPEFBCIIDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1DC1840", Offset = "0x1DC0240", VA = "0x181DC1840")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LMKMPEDMIPF<T> : global::DJAOLOOILHN<T>, OFEHPCFKLFI, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CDABGDFLPAG<T> : OFEHPCFKLFI, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JHEBFNPDEIE
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NFCKBLDGIJC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class BEDJBPEJNGJ<T> : global::APDKDJOBEAE<T>, global::LMKMPEDMIPF<T>, global::DJAOLOOILHN<T>, OFEHPCFKLFI, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class NCHFBBNENKG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public BEDJBPEJNGJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
			public NCHFBBNENKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x390C760", Offset = "0x390B160", VA = "0x18390C760")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x34E7D20", Offset = "0x34E6720", VA = "0x1834E7D20")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::CMDAMFNAEHI<T> IKAEBAJMLPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool GDMABLBEEPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T JCJDNADEMKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool ILMLECMLEKB;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4867F80", Offset = "0x4866980", VA = "0x184867F80")]
		public BEDJBPEJNGJ(global::CMDAMFNAEHI<T> IKAEBAJMLPA, ObjectPool GDMABLBEEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4867E40", Offset = "0x4866840", VA = "0x184867E40", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class BOLEDBEDHEK<T> : DGKGHLNCFMM, global::CDABGDFLPAG<T>, OFEHPCFKLFI, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class ICECBNLKKOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public BOLEDBEDHEK<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
			public ICECBNLKKOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x40644C0", Offset = "0x4062EC0", VA = "0x1840644C0")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x40645A0", Offset = "0x4062FA0", VA = "0x1840645A0")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private global::CMDAMFNAEHI<T> IKAEBAJMLPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool ILMLECMLEKB;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x362A5D0", Offset = "0x3628FD0", VA = "0x18362A5D0")]
		public BOLEDBEDHEK(global::CMDAMFNAEHI<T> IKAEBAJMLPA, ObjectPool GDMABLBEEPH, int BJPKBMKFJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x362A580", Offset = "0x3628F80", VA = "0x18362A580", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GJOBAIDHCJD<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NFCKBLDGIJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::APDKDJOBEAE<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::CMDAMFNAEHI<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public GJOBAIDHCJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7460", Offset = "0x3FE5E60", VA = "0x183FE7460")]
		internal void <Exists>b__0(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7500", Offset = "0x3FE5F00", VA = "0x183FE7500")]
		internal void <Exists>b__1(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7560", Offset = "0x3FE5F60", VA = "0x183FE7560")]
		internal void <Exists>b__2()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<JHEBFNPDEIE> NJJBBHFCCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private DGKNKPGEKAN DJOMNNNNCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool GDMABLBEEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool ILMLECMLEKB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool IIMFOBGAOIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1DBF7F0", Offset = "0x1DBE1F0", VA = "0x181DBF7F0")]
	private static void NABMIEOJHFL(Component DHGNJCDIFDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1DBFC50", Offset = "0x1DBE650", VA = "0x181DBFC50")]
	public NFCKBLDGIJC(string FJMCJNMPNJB, int JDFPLFGMKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3C805D0", Offset = "0x3C7EFD0", VA = "0x183C805D0")]
	public global::LMKMPEDMIPF<T> NFDNIPICANI<T>(AssetReference DBDNOBGDADG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3C80520", Offset = "0x3C7EF20", VA = "0x183C80520")]
	public global::CDABGDFLPAG<T> JFEFEKPOIAJ<T>(AssetReference DBDNOBGDADG, int HGMGPFAJPJI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3C80660", Offset = "0x3C7F060", VA = "0x183C80660")]
	public global::DJAOLOOILHN<bool> OJCAMDKMMGI<T>(AssetReference DBDNOBGDADG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1DBF5A0", Offset = "0x1DBDFA0", VA = "0x181DBF5A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1DBF6B0", Offset = "0x1DBE0B0", VA = "0x181DBF6B0")]
	private void FNMBNCJABKC(UnityEngine.Object EHBBIPDMLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1DBFA40", Offset = "0x1DBE440", VA = "0x181DBFA40")]
	private ObjectPool OEFHMKDAEJL(string FJMCJNMPNJB)
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
		private static GlobalPool MMIIBPAPJJA;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject IFHPGEECOJG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool FINLHCLDLDF
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1DBF030", Offset = "0x1DBDA30", VA = "0x181DBF030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x30DDEA0", Offset = "0x30DC8A0", VA = "0x1830DDEA0")]
		public static void SafeRelease<T>(T OMHIFHKMIMJ) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1DBEF30", Offset = "0x1DBD930", VA = "0x181DBEF30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1DBF020", Offset = "0x1DBDA20", VA = "0x181DBF020")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, IEHJEGPOBHH> ANFNCJMGFEJ;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x36885C0", Offset = "0x3686FC0", VA = "0x1836885C0")]
		public T Acquire<T>(T INOMEBNKFPO, [Optional] Action<Component> EEGBJAJCPHJ) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3688810", Offset = "0x3687210", VA = "0x183688810")]
		public bool Release<T>(T OMHIFHKMIMJ) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x36887B0", Offset = "0x36871B0", VA = "0x1836887B0")]
		public void Prefill<T>(T INOMEBNKFPO, int NNIPDENFCEJ, [Optional] Action<Component> PFGEMHGHDHL) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3688700", Offset = "0x3687100", VA = "0x183688700")]
		public bool Exists<T>(T INOMEBNKFPO) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3688650", Offset = "0x3687050", VA = "0x183688650")]
		public void Clear<T>(T INOMEBNKFPO) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1DC0FD0", Offset = "0x1DBF9D0", VA = "0x181DC0FD0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3688480", Offset = "0x3686E80", VA = "0x183688480")]
		private IEHJEGPOBHH AABFEEBEGKP<T>(T INOMEBNKFPO) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		public void TrackInstantiation(string EAANGHCHBPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		public void EnableStats(bool ILPGCJOHBBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1DC1120", Offset = "0x1DBFB20", VA = "0x181DC1120")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class IEHJEGPOBHH
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface BHJICHLCMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JBHAJKJLGKG(bool DKMFIFCJODD);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract Component JNNPGNEMIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract string KPDCCEJPHFL
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int LIHGMCPDGJF
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void JFEFEKPOIAJ(int HGMGPFAJPJI, Action<Component> PFGEMHGHDHL);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Component NFDNIPICANI(Action<Component> EEGBJAJCPHJ);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool CFLDMNJOPIN(Component BHBKIKDKFPA);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void PDOAHDCGLGB();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1DBF3F0", Offset = "0x1DBDDF0", VA = "0x181DBF3F0")]
	protected void PEKCLBLFDEL(Component OMHIFHKMIMJ, bool DKMFIFCJODD, bool NPPOHHMDJEK, bool PMOPNBLNOBH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1DBF1F0", Offset = "0x1DBDBF0", VA = "0x181DBF1F0")]
	protected void INFIILABFOH(Transform MNAOLFIILKI, bool DKMFIFCJODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	protected IEHJEGPOBHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class CKAKEIAIFFF<T> : IEHJEGPOBHH where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T INOMEBNKFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool OAHLEJAFMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool NPPOHHMDJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> LKAGMALBCLD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Component JNNPGNEMIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override string KPDCCEJPHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x453C970", Offset = "0x453B370", VA = "0x18453C970", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override int LIHGMCPDGJF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x453CE70", Offset = "0x453B870", VA = "0x18453CE70", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x453D090", Offset = "0x453BA90", VA = "0x18453D090")]
	public CKAKEIAIFFF(T INOMEBNKFPO, ObjectPool OAHLEJAFMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x453C990", Offset = "0x453B390", VA = "0x18453C990", Slot = "7")]
	public override void JFEFEKPOIAJ(int HGMGPFAJPJI, Action<Component> EEGBJAJCPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x453CC00", Offset = "0x453B600", VA = "0x18453CC00", Slot = "8")]
	public override Component NFDNIPICANI(Action<Component> EEGBJAJCPHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x453C7E0", Offset = "0x453B1E0", VA = "0x18453C7E0", Slot = "9")]
	public override bool CFLDMNJOPIN(Component BHBKIKDKFPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x453CEA0", Offset = "0x453B8A0", VA = "0x18453CEA0", Slot = "10")]
	public override void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x453CAA0", Offset = "0x453B4A0", VA = "0x18453CAA0")]
	private T JNNONANPFKH()
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
		public interface IHNGFANMKIO
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			GameObject FCBCGNBDHDG
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
		[Cpp2IlInjected.Address(RVA = "0x1DC0C00", Offset = "0x1DBF600", VA = "0x181DC0C00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1DC0F50", Offset = "0x1DBF950", VA = "0x181DC0F50")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool MMIIBPAPJJA;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject IFHPGEECOJG;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static PersistentGlobalPool FINLHCLDLDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x1DC1290", Offset = "0x1DBFC90", VA = "0x181DC1290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1DC11A0", Offset = "0x1DBFBA0", VA = "0x181DC11A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1DBF020", Offset = "0x1DBDA20", VA = "0x181DBF020")]
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
		public IEHJEGPOBHH PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x877E70", Offset = "0x876870", VA = "0x180877E70")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface ILAPAFAOIPP
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JGOOADJBHNL(PooledParticle.NIFNCFFNHHF DNDFMPOMIEK);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum OIGPFCLEABP
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
		public enum NIFNCFFNHHF
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
		public interface FPAPIKBEIOE
		{
			[Cpp2IlInjected.Token(Token = "0x17000015")]
			bool JFJAALPJHCI
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			Vector3 MJPHOLEMDOI
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			Camera BJOLDCKLHNM
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
			[Cpp2IlInjected.Address(RVA = "0x1A57840", Offset = "0x1A56240", VA = "0x181A57840")]
			public ColorConfiguration(ParticleSystem FIPNPLOAONN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x1DBEC40", Offset = "0x1DBD640", VA = "0x181DBEC40")]
			public void ICIAKHAEPOI(Color CPPINAHFMCO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class IPNIBICDLAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public IPNIBICDLAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1DBF570", Offset = "0x1DBDF70", VA = "0x181DBF570")]
			internal void <SetRenderingEnabled>b__0(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class OHKBIPGEOHM : IEnumerator<FJMKJDOKGFB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private FJMKJDOKGFB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private FPAPIKBEIOE <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private FJMKJDOKGFB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x84FBB0", Offset = "0x84E5B0", VA = "0x18084FBB0")]
			[DebuggerHidden]
			public OHKBIPGEOHM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x1DC0520", Offset = "0x1DBEF20", VA = "0x181DC0520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x1DC0BC0", Offset = "0x1DBF5C0", VA = "0x181DC0BC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class ENOFMJJOGJA : IEnumerator<FJMKJDOKGFB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private FJMKJDOKGFB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private FJMKJDOKGFB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x84FBB0", Offset = "0x84E5B0", VA = "0x18084FBB0")]
			[DebuggerHidden]
			public ENOFMJJOGJA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1DBEE30", Offset = "0x1DBD830", VA = "0x181DBEE30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x1DBEEF0", Offset = "0x1DBD8F0", VA = "0x181DBEEF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> FFPMMDNOLCD;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<ILAPAFAOIPP> JEJOBGCDPFB;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> OBKJKFPKOJO;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static LLDNPBCCADD OOHAGLHODNL;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float NHBNKHHECDE = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool FKKCOCODHOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int MNHJNGIJGPC;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private NIFNCFFNHHF category;

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
		private ParticleSystem.MinMaxGradient[] BJLHFPMGEKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool NPJNONDAELL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float MDHCPLNCDBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float OHIPLBECFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform OFDPFHFJFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 ECBLJILBCBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 DKDJHHDOJOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private OIGPFCLEABP EGACNHIFHKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private LLDNPBCCADD MPBGEPJFCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool BGGPNJPFHMO;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static IEnumerable<PooledParticle> JFCDOPNBGED
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x1DC5130", Offset = "0x1DC3B30", VA = "0x181DC5130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public NIFNCFFNHHF AKEGHPCAHOG
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7E5640", Offset = "0x7E4040", VA = "0x1807E5640")]
			get
			{
				return default(NIFNCFFNHHF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int AOFPLFHPIEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x767550", Offset = "0x765F50", VA = "0x180767550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool CFHHAFMAFEH
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x1DC4E20", Offset = "0x1DC3820", VA = "0x181DC4E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static int KAPPPJNFPLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x1DC4FB0", Offset = "0x1DC39B0", VA = "0x181DC4FB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected static bool HGNBCCHNNHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x1DC3300", Offset = "0x1DC1D00", VA = "0x181DC3300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ParticleSystem HJOPKPOLJFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7DAB60", Offset = "0x7D9560", VA = "0x1807DAB60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ParticleSystem[] ANCAHGEFOKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D2D70", VA = "0x1807D4370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private ParticleSystemRenderer[] POADHNELAIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8464B0", Offset = "0x844EB0", VA = "0x1808464B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private OIGPFCLEABP ONEJOOPGPMI
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x94C2E0", Offset = "0x94ACE0", VA = "0x18094C2E0")]
			get
			{
				return default(OIGPFCLEABP);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x1DC1EB0", Offset = "0x1DC08B0", VA = "0x181DC1EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action CBDFDHENJDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x1DC4D80", Offset = "0x1DC3780", VA = "0x181DC4D80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x1DC5190", Offset = "0x1DC3B90", VA = "0x181DC5190")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4920", Offset = "0x1DC3320", VA = "0x181DC4920")]
		public static PooledParticle TryPlayPrefab(PooledParticle INOMEBNKFPO, Vector3 LHCEFCJDGIJ, Quaternion FDBNIAOOEMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4730", Offset = "0x1DC3130", VA = "0x181DC4730")]
		public static PooledParticle TryPlayPrefab(PooledParticle INOMEBNKFPO, Vector3 LHCEFCJDGIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3DA0", Offset = "0x1DC27A0", VA = "0x181DC3DA0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2950", Offset = "0x1DC1350", VA = "0x181DC2950")]
		private void KNIGNCIBLDM(bool HAHGELBMJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2410", Offset = "0x1DC0E10", VA = "0x181DC2410")]
		[IteratorStateMachine(typeof(OHKBIPGEOHM))]
		private static IEnumerator<FJMKJDOKGFB> EAFHJDDNMFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1DC18E0", Offset = "0x1DC02E0", VA = "0x181DC18E0")]
		private static void AIIHMJGEDBH(Stopwatch FCGBKHLAIBH, Vector3 HNAGAHKPCOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2460", Offset = "0x1DC0E60", VA = "0x181DC2460")]
		private static int ENICDPCDPHA(PooledParticle OLGHNLLKLDL, PooledParticle JPDHFMDKHGF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2680", Offset = "0x1DC1080", VA = "0x181DC2680")]
		private static int JGOOADJBHNL(NIFNCFFNHHF DNDFMPOMIEK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2080", Offset = "0x1DC0A80", VA = "0x181DC2080")]
		protected void CKADFGPNLPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2CD0", Offset = "0x1DC16D0", VA = "0x181DC2CD0")]
		protected void NLNGCIFAPCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1DC1C70", Offset = "0x1DC0670", VA = "0x181DC1C70", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2A30", Offset = "0x1DC1430", VA = "0x181DC2A30")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3280", Offset = "0x1DC1C80", VA = "0x181DC3280")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1DC28D0", Offset = "0x1DC12D0", VA = "0x181DC28D0")]
		[IteratorStateMachine(typeof(ENOFMJJOGJA))]
		private IEnumerator<FJMKJDOKGFB> KEFCAFDAIOB(float KLFNPNLGLPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1DC1ED0", Offset = "0x1DC08D0", VA = "0x181DC1ED0")]
		private void CFLDMNJOPIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4540", Offset = "0x1DC2F40", VA = "0x181DC4540")]
		public void SetDuration(float KLFNPNLGLPF, bool HJKGPOAIGNB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3A80", Offset = "0x1DC2480", VA = "0x181DC3A80")]
		public void Play(Transform BOGNHCICNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3460", Offset = "0x1DC1E60", VA = "0x181DC3460")]
		public void Play(Transform BOGNHCICNFJ, bool NPODMIDIBEA, float BAFENNEMNLN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1DC35B0", Offset = "0x1DC1FB0", VA = "0x181DC35B0")]
		public void Play(Transform BOGNHCICNFJ, Vector3 DKDJHHDOJOM, bool NPODMIDIBEA, float BAFENNEMNLN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3830", Offset = "0x1DC2230", VA = "0x181DC3830")]
		public void Play(Transform GHBFLHDELAN, Quaternion FDBNIAOOEMB, bool NPODMIDIBEA = false, float BAFENNEMNLN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3700", Offset = "0x1DC2100", VA = "0x181DC3700")]
		public void Play(Transform GHBFLHDELAN, Vector3 DKDJHHDOJOM, Quaternion FDBNIAOOEMB, bool NPODMIDIBEA = false, float BAFENNEMNLN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3390", Offset = "0x1DC1D90", VA = "0x181DC3390")]
		public void Play(Vector3 LHCEFCJDGIJ, Quaternion FDBNIAOOEMB, Vector3 PBLNDACCBGI, bool NPODMIDIBEA = false, float BAFENNEMNLN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3BC0", Offset = "0x1DC25C0", VA = "0x181DC3BC0")]
		public void Play(Vector3 LHCEFCJDGIJ, Quaternion FDBNIAOOEMB, bool NPODMIDIBEA = false, float BAFENNEMNLN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3970", Offset = "0x1DC2370", VA = "0x181DC3970")]
		public void Play(bool NPODMIDIBEA = false, float BAFENNEMNLN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1DC46A0", Offset = "0x1DC30A0", VA = "0x181DC46A0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4610", Offset = "0x1DC3010", VA = "0x181DC4610")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2280", Offset = "0x1DC0C80", VA = "0x181DC2280")]
		private void DONGMNBBCDP(float KLFNPNLGLPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2510", Offset = "0x1DC0F10", VA = "0x181DC2510")]
		private void IPFCOEFNNDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3C80", Offset = "0x1DC2680", VA = "0x181DC3C80")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3F40", Offset = "0x1DC2940", VA = "0x181DC3F40")]
		public void SetColor(Color CPPINAHFMCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2790", Offset = "0x1DC1190", VA = "0x181DC2790")]
		private void JNIOPDBPBDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4D20", Offset = "0x1DC3720", VA = "0x181DC4D20")]
		public PooledParticle()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NNIFMOPFNIE
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static byte[] FNNHBCFPBIC;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static int IPKGAJADJFC;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static int DIJMLDGECMG;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static BigInteger DGOGINAIMEE;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public NNIFMOPFNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1DBFEF0", Offset = "0x1DBE8F0", VA = "0x181DBFEF0")]
	private static string DAIOEIOFDHG(byte[] LPDJCHOFJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0000", Offset = "0x1DBEA00", VA = "0x181DC0000")]
	public static string LIOEFPBPBEO(byte[] AHIMNOMEIMA, bool ADOOPHPHCDD)
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
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
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
