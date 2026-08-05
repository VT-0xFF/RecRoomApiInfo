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
		[Cpp2IlInjected.Address(RVA = "0x1E24CC0", Offset = "0x1E234C0", VA = "0x181E24CC0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles LGELJKPCDJN, float MKKBDOCHIGG, Vector3 LPADDFNBONE, Quaternion OIFAPGIKFEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1E24AC0", Offset = "0x1E232C0", VA = "0x181E24AC0")]
		public void SetDamageValue(float MKKBDOCHIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1E24E80", Offset = "0x1E23680", VA = "0x181E24E80")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OAAMJDMOOPO<T> : global::AGDEEHNAPKP<T>, MLEPGEJLFCO, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EEOAOBPAFDN<T> : MLEPGEJLFCO, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LDMPAGCPLBG
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KFGKFIHMMAG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class LHGIOLFLKHG<T> : global::MJBDKPPKHFK<T>, global::OAAMJDMOOPO<T>, global::AGDEEHNAPKP<T>, MLEPGEJLFCO, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class KAFIJBLNHNL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public LHGIOLFLKHG<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
			public KAFIJBLNHNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x37BA140", Offset = "0x37B8940", VA = "0x1837BA140")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2EEC720", Offset = "0x2EEAF20", VA = "0x182EEC720")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::FGIBMGOBPLI<T> OCCNANJLNIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool LOHJIBBFOLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T NIDJHACIMJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool KAIBIFDFALJ;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x390DE40", Offset = "0x390C640", VA = "0x18390DE40")]
		public LHGIOLFLKHG(global::FGIBMGOBPLI<T> OCCNANJLNIE, ObjectPool LOHJIBBFOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x390DD00", Offset = "0x390C500", VA = "0x18390DD00", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class JAGDPHMHMJM<T> : AMPMBAOHAPE, global::EEOAOBPAFDN<T>, MLEPGEJLFCO, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class LFAJDGEHMJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public JAGDPHMHMJM<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
			public LFAJDGEHMJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x39096A0", Offset = "0x3907EA0", VA = "0x1839096A0")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x295D570", Offset = "0x295BD70", VA = "0x18295D570")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private global::FGIBMGOBPLI<T> OCCNANJLNIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool KAIBIFDFALJ;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x32A1000", Offset = "0x329F800", VA = "0x1832A1000")]
		public JAGDPHMHMJM(global::FGIBMGOBPLI<T> OCCNANJLNIE, ObjectPool LOHJIBBFOLJ, int DFCKALLJGMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x32A0FB0", Offset = "0x329F7B0", VA = "0x1832A0FB0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CJMPMDMPOAE<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public KFGKFIHMMAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::MJBDKPPKHFK<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::FGIBMGOBPLI<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		public CJMPMDMPOAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x386A470", Offset = "0x3868C70", VA = "0x18386A470")]
		internal void <Exists>b__0(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x386A510", Offset = "0x3868D10", VA = "0x18386A510")]
		internal void <Exists>b__1(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x386A570", Offset = "0x3868D70", VA = "0x18386A570")]
		internal void <Exists>b__2()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<LDMPAGCPLBG> BFKPHJNHCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private CCCGNAJCKMN CGEAFKFNCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool LOHJIBBFOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool KAIBIFDFALJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool LDHDABIIEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1E22FA0", Offset = "0x1E217A0", VA = "0x181E22FA0")]
	private static void FNBNGKEDBFI(Component CHHHDNBJJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1E233B0", Offset = "0x1E21BB0", VA = "0x181E233B0")]
	public KFGKFIHMMAG(string HFKKJONCLJD, int LOLONBOLBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2E2A140", Offset = "0x2E28940", VA = "0x182E2A140")]
	public global::OAAMJDMOOPO<T> LLHBACCELBH<T>(AssetReference DPEHHPOILIP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2E2A090", Offset = "0x2E28890", VA = "0x182E2A090")]
	public global::EEOAOBPAFDN<T> LBNPBPKMGJA<T>(AssetReference DPEHHPOILIP, int LGKBEOCJMLG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2E29DA0", Offset = "0x2E285A0", VA = "0x182E29DA0")]
	public global::AGDEEHNAPKP<bool> FKKMCEBMOMF<T>(AssetReference DPEHHPOILIP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1E22D00", Offset = "0x1E21500", VA = "0x181E22D00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1E231F0", Offset = "0x1E219F0", VA = "0x181E231F0")]
	private void PGFGMLNEDEM(UnityEngine.Object GFNKHHJBHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1E22E10", Offset = "0x1E21610", VA = "0x181E22E10")]
	private ObjectPool FHCOHGFONMI(string HFKKJONCLJD)
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
		private static GlobalPool KHEKGLLBKCN;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject FJHPDEGHDBE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool KGCADEGMLJC
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1E227C0", Offset = "0x1E20FC0", VA = "0x181E227C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1E226C0", Offset = "0x1E20EC0", VA = "0x181E226C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1E227B0", Offset = "0x1E20FB0", VA = "0x181E227B0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, HIJGDGKFPDI> GHBBEFNPBEA;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x39692D0", Offset = "0x3967AD0", VA = "0x1839692D0")]
		public T Acquire<T>(T LGELJKPCDJN, [Optional] Action<Component> MOLNFAEIDLC) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3969660", Offset = "0x3967E60", VA = "0x183969660")]
		public bool Release<T>(T ODMJCJPGHNI) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3969600", Offset = "0x3967E00", VA = "0x183969600")]
		public void Prefill<T>(T LGELJKPCDJN, int BCCEAMLFENN, [Optional] Action<Component> LFDGEABACFD) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3969410", Offset = "0x3967C10", VA = "0x183969410")]
		public bool Exists<T>(T LGELJKPCDJN) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3969360", Offset = "0x3967B60", VA = "0x183969360")]
		public void Clear<T>(T LGELJKPCDJN) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1E24610", Offset = "0x1E22E10", VA = "0x181E24610")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x39694C0", Offset = "0x3967CC0", VA = "0x1839694C0")]
		private HIJGDGKFPDI HDCLKCJIGOH<T>(T LGELJKPCDJN) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
		public void TrackInstantiation(string KOGBJPGAFGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
		public void EnableStats(bool DELFGBKLLLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1E24760", Offset = "0x1E22F60", VA = "0x181E24760")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class HIJGDGKFPDI
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface LLKOGAMBLGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CNAHMNDCALB(bool JHLBHCGIPKF);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract Component JPJAPPECPFM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract string AKFKAJPCNFD
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int KFJKNGGDJAO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void LBNPBPKMGJA(int LGKBEOCJMLG, Action<Component> LFDGEABACFD);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Component LLHBACCELBH(Action<Component> MOLNFAEIDLC);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool GCLFHHNKHLO(Component FDEBBPLENLF);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void OJEEPLKEKIC();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1E22980", Offset = "0x1E21180", VA = "0x181E22980")]
	protected void APGFINKLMNI(Component ODMJCJPGHNI, bool JHLBHCGIPKF, bool GELAHHFEKHP, bool DFNNDCLNIJF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1E22B00", Offset = "0x1E21300", VA = "0x181E22B00")]
	protected void POOFBCCMBOD(Transform EHIJIKNEIAF, bool JHLBHCGIPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	protected HIJGDGKFPDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class CAFOLADMCDF<T> : HIJGDGKFPDI where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T LGELJKPCDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool HFLFKBGDGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool GELAHHFEKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> HPDMOAABCNI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Component JPJAPPECPFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override string AKFKAJPCNFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x40F1660", Offset = "0x40EFE60", VA = "0x1840F1660", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override int KFJKNGGDJAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x40F1680", Offset = "0x40EFE80", VA = "0x1840F1680", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x40F1C20", Offset = "0x40F0420", VA = "0x1840F1C20")]
	public CAFOLADMCDF(T LGELJKPCDJN, ObjectPool HFLFKBGDGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x40F16B0", Offset = "0x40EFEB0", VA = "0x1840F16B0", Slot = "7")]
	public override void LBNPBPKMGJA(int LGKBEOCJMLG, Action<Component> MOLNFAEIDLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x40F17C0", Offset = "0x40EFFC0", VA = "0x1840F17C0", Slot = "8")]
	public override Component LLHBACCELBH(Action<Component> MOLNFAEIDLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x40F14D0", Offset = "0x40EFCD0", VA = "0x1840F14D0", Slot = "9")]
	public override bool GCLFHHNKHLO(Component FDEBBPLENLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x40F1A30", Offset = "0x40F0230", VA = "0x1840F1A30", Slot = "10")]
	public override void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x40F1370", Offset = "0x40EFB70", VA = "0x1840F1370")]
	private T ELDLENJMBIO()
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
		public interface AAPMLGGPOGG
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			GameObject GCDLNKNDHCO
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
		[Cpp2IlInjected.Address(RVA = "0x1E24240", Offset = "0x1E22A40", VA = "0x181E24240")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1E24590", Offset = "0x1E22D90", VA = "0x181E24590")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool KHEKGLLBKCN;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject FJHPDEGHDBE;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static PersistentGlobalPool KGCADEGMLJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x1E248D0", Offset = "0x1E230D0", VA = "0x181E248D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1E247E0", Offset = "0x1E22FE0", VA = "0x181E247E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1E227B0", Offset = "0x1E20FB0", VA = "0x181E227B0")]
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
		public HIJGDGKFPDI PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6E7F30", Offset = "0x6E6730", VA = "0x1806E7F30")]
		public PooledObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private enum MAMGKIJLIOM
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
		public interface LGOOJFBINOJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000010")]
			bool LDIJBIAPALG
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			Vector3 IBAHHKIOKJE
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			Camera OMKMFLLFJMF
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
			[Cpp2IlInjected.Address(RVA = "0x1AFAD10", Offset = "0x1AF9510", VA = "0x181AFAD10")]
			public ColorConfiguration(ParticleSystem AKNOJGIBJJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x1E224D0", Offset = "0x1E20CD0", VA = "0x181E224D0")]
			public void NMAOBGPHHFC(Color NNPLNBENDGM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class ODFCNPLLJNI : IEnumerator<KDCGDINMKGL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private KDCGDINMKGL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private LGOOJFBINOJ <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private KDCGDINMKGL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6D1490", Offset = "0x6CFC90", VA = "0x1806D1490")]
			[DebuggerHidden]
			public ODFCNPLLJNI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x1E23750", Offset = "0x1E21F50", VA = "0x181E23750", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x1E24200", Offset = "0x1E22A00", VA = "0x181E24200", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class KIFEPIIGDKC : IEnumerator<KDCGDINMKGL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private KDCGDINMKGL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private KDCGDINMKGL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6D1490", Offset = "0x6CFC90", VA = "0x1806D1490")]
			[DebuggerHidden]
			public KIFEPIIGDKC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x1E23650", Offset = "0x1E21E50", VA = "0x181E23650", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x1E23710", Offset = "0x1E21F10", VA = "0x181E23710", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> CCMJEFPNPPG;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static List<PooledParticle> NLAHHHBFCFD;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static PKIGMKLPPJG CMBHGBKPCBP;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const float CNCFPNNOCKC = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static bool MIMLMCHNOIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		protected int NMBEIAFBIDP;

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
		private ParticleSystem.MinMaxGradient[] NKLIFMCGAEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool GHCAAOLDJAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float BDCDKGDNIDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float DCNBPFGFKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Transform HCEMIDKKPFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Vector3 MCHPNOGLBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private Vector3 CKOLFBHFJIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private MAMGKIJLIOM DJIBLEJPHLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private PKIGMKLPPJG DPNPFEIAPCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		protected bool ICMJMOOLMNK;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected static bool MEPFLKGGHJM
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x1E25A10", Offset = "0x1E24210", VA = "0x181E25A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ParticleSystem OONLOPDGIJC
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6F5FE0", Offset = "0x6F47E0", VA = "0x1806F5FE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6F5A60", Offset = "0x6F4260", VA = "0x1806F5A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ParticleSystem[] BCDACOMNFOG
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6F5B40", Offset = "0x6F4340", VA = "0x1806F5B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6F5A70", Offset = "0x6F4270", VA = "0x1806F5A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private ParticleSystemRenderer[] EIBHJEDAOBC
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x726A30", Offset = "0x725230", VA = "0x180726A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x726A50", Offset = "0x725250", VA = "0x180726A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private MAMGKIJLIOM NMEMEGMIOID
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7E9600", Offset = "0x7E7E00", VA = "0x1807E9600")]
			get
			{
				return default(MAMGKIJLIOM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x1E259F0", Offset = "0x1E241F0", VA = "0x181E259F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action LJLOOBDFGPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x1E27D10", Offset = "0x1E26510", VA = "0x181E27D10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x1E27DB0", Offset = "0x1E265B0", VA = "0x181E27DB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1E27970", Offset = "0x1E26170", VA = "0x181E27970")]
		public static PooledParticle TryPlayPrefab(PooledParticle LGELJKPCDJN, Vector3 LPADDFNBONE, Quaternion OIFAPGIKFEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1E27780", Offset = "0x1E25F80", VA = "0x181E27780")]
		public static PooledParticle TryPlayPrefab(PooledParticle LGELJKPCDJN, Vector3 LPADDFNBONE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1E26DF0", Offset = "0x1E255F0", VA = "0x181E26DF0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1E25160", Offset = "0x1E23960", VA = "0x181E25160")]
		private void DIBLIAIJKAG(bool JDGAOKBHEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1E25230", Offset = "0x1E23A30", VA = "0x181E25230")]
		[IteratorStateMachine(typeof(ODFCNPLLJNI))]
		private static IEnumerator<KDCGDINMKGL> EPHIACMFAOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1E25AE0", Offset = "0x1E242E0", VA = "0x181E25AE0")]
		protected void JDIIAMJDBNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1E254B0", Offset = "0x1E23CB0", VA = "0x181E254B0")]
		protected void HBKLHEIDCNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1E24F20", Offset = "0x1E23720", VA = "0x181E24F20", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1E25E10", Offset = "0x1E24610", VA = "0x181E25E10")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1E26360", Offset = "0x1E24B60", VA = "0x181E26360")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1E25280", Offset = "0x1E23A80", VA = "0x181E25280")]
		[IteratorStateMachine(typeof(KIFEPIIGDKC))]
		private IEnumerator<KDCGDINMKGL> FGNJOEGGKFP(float LHKNOFOGOFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1E25300", Offset = "0x1E23B00", VA = "0x181E25300")]
		private void GCLFHHNKHLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1E27590", Offset = "0x1E25D90", VA = "0x181E27590")]
		public void SetDuration(float LHKNOFOGOFA, bool OKEKDLKHAOL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1E26AD0", Offset = "0x1E252D0", VA = "0x181E26AD0")]
		public void Play(Transform KEFMCPDGELC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1E264B0", Offset = "0x1E24CB0", VA = "0x181E264B0")]
		public void Play(Transform KEFMCPDGELC, bool MILNOABFKNI, float LHJHMLDMEGB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1E26600", Offset = "0x1E24E00", VA = "0x181E26600")]
		public void Play(Transform KEFMCPDGELC, Vector3 CKOLFBHFJIG, bool MILNOABFKNI, float LHJHMLDMEGB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1E26880", Offset = "0x1E25080", VA = "0x181E26880")]
		public void Play(Transform IJFKMLHMNOM, Quaternion OIFAPGIKFEG, bool MILNOABFKNI = false, float LHJHMLDMEGB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1E26750", Offset = "0x1E24F50", VA = "0x181E26750")]
		public void Play(Transform IJFKMLHMNOM, Vector3 CKOLFBHFJIG, Quaternion OIFAPGIKFEG, bool MILNOABFKNI = false, float LHJHMLDMEGB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1E263E0", Offset = "0x1E24BE0", VA = "0x181E263E0")]
		public void Play(Vector3 LPADDFNBONE, Quaternion OIFAPGIKFEG, Vector3 ICKCINMFDON, bool MILNOABFKNI = false, float LHJHMLDMEGB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1E26C10", Offset = "0x1E25410", VA = "0x181E26C10")]
		public void Play(Vector3 LPADDFNBONE, Quaternion OIFAPGIKFEG, bool MILNOABFKNI = false, float LHJHMLDMEGB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1E269C0", Offset = "0x1E251C0", VA = "0x181E269C0")]
		public void Play(bool MILNOABFKNI = false, float LHJHMLDMEGB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1E276F0", Offset = "0x1E25EF0", VA = "0x181E276F0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1E27660", Offset = "0x1E25E60", VA = "0x181E27660")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1E25C80", Offset = "0x1E24480", VA = "0x181E25C80")]
		private void KHAFBJIJNOB(float LHKNOFOGOFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1E261F0", Offset = "0x1E249F0", VA = "0x181E261F0")]
		private void MCAAPLONCEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1E26CD0", Offset = "0x1E254D0", VA = "0x181E26CD0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1E26F90", Offset = "0x1E25790", VA = "0x181E26F90")]
		public void SetColor(Color NNPLNBENDGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1E260B0", Offset = "0x1E248B0", VA = "0x181E260B0")]
		private void MBBMLOJCFGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1E27CB0", Offset = "0x1E264B0", VA = "0x181E27CB0")]
		public PooledParticle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1E25200", Offset = "0x1E23A00", VA = "0x181E25200")]
		[CompilerGenerated]
		private void EPELNGLCAEA(ParticleSystemRenderer OOEOJHLLNKE)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BAADKGJHJEL
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static byte[] ANBHIGGKLGA;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static int CIBDKMIJIHM;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static int HHBBDHEOEDG;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static BigInteger JHIBJFGIFBI;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public BAADKGJHJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1E21EA0", Offset = "0x1E206A0", VA = "0x181E21EA0")]
	private static string DPBKDPCCPCK(byte[] ENHIJCCJFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1E21FB0", Offset = "0x1E207B0", VA = "0x181E21FB0")]
	public static string NNIAAAJCFNJ(byte[] CDDAIIMDJCN, bool FNAKCEJPGOO)
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
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
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
