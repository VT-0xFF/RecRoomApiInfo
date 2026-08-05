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
		[Cpp2IlInjected.Address(RVA = "0x5DB7A80", Offset = "0x5DB6A80", VA = "0x185DB7A80")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles LGELJKPCDJN, float MKKBDOCHIGG, Vector3 LPADDFNBONE, Quaternion OIFAPGIKFEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7880", Offset = "0x5DB6880", VA = "0x185DB7880")]
		public void SetDamageValue(float MKKBDOCHIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7C40", Offset = "0x5DB6C40", VA = "0x185DB7C40")]
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
			[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
			public KAFIJBLNHNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x28F18B0", Offset = "0x28F08B0", VA = "0x1828F18B0")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1F79660", Offset = "0x1F78660", VA = "0x181F79660")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AA62E0", Offset = "0x2AA52E0", VA = "0x182AA62E0")]
		public LHGIOLFLKHG(global::FGIBMGOBPLI<T> OCCNANJLNIE, ObjectPool LOHJIBBFOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2AA61A0", Offset = "0x2AA51A0", VA = "0x182AA61A0", Slot = "27")]
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
			[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
			public LFAJDGEHMJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1B40", Offset = "0x2AA0B40", VA = "0x182AA1B40")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x19E95A0", Offset = "0x19E85A0", VA = "0x1819E95A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x232F150", Offset = "0x232E150", VA = "0x18232F150")]
		public JAGDPHMHMJM(global::FGIBMGOBPLI<T> OCCNANJLNIE, ObjectPool LOHJIBBFOLJ, int DFCKALLJGMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x232F100", Offset = "0x232E100", VA = "0x18232F100", Slot = "19")]
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
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		public CJMPMDMPOAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2A02860", Offset = "0x2A01860", VA = "0x182A02860")]
		internal void <Exists>b__0(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2A02900", Offset = "0x2A01900", VA = "0x182A02900")]
		internal void <Exists>b__1(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2A02960", Offset = "0x2A01960", VA = "0x182A02960")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5D60", Offset = "0x5DB4D60", VA = "0x185DB5D60")]
	private static void FNBNGKEDBFI(Component CHHHDNBJJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6170", Offset = "0x5DB5170", VA = "0x185DB6170")]
	public KFGKFIHMMAG(string HFKKJONCLJD, int LOLONBOLBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6E40", Offset = "0x1EB5E40", VA = "0x181EB6E40")]
	public global::OAAMJDMOOPO<T> LLHBACCELBH<T>(AssetReference DPEHHPOILIP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6D90", Offset = "0x1EB5D90", VA = "0x181EB6D90")]
	public global::EEOAOBPAFDN<T> LBNPBPKMGJA<T>(AssetReference DPEHHPOILIP, int LGKBEOCJMLG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6AA0", Offset = "0x1EB5AA0", VA = "0x181EB6AA0")]
	public global::AGDEEHNAPKP<bool> FKKMCEBMOMF<T>(AssetReference DPEHHPOILIP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5AC0", Offset = "0x5DB4AC0", VA = "0x185DB5AC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5FB0", Offset = "0x5DB4FB0", VA = "0x185DB5FB0")]
	private void PGFGMLNEDEM(UnityEngine.Object GFNKHHJBHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5BD0", Offset = "0x5DB4BD0", VA = "0x185DB5BD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DB5580", Offset = "0x5DB4580", VA = "0x185DB5580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5480", Offset = "0x5DB4480", VA = "0x185DB5480")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5570", Offset = "0x5DB4570", VA = "0x185DB5570")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B01770", Offset = "0x2B00770", VA = "0x182B01770")]
		public T Acquire<T>(T LGELJKPCDJN, [Optional] Action<Component> MOLNFAEIDLC) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B01B00", Offset = "0x2B00B00", VA = "0x182B01B00")]
		public bool Release<T>(T ODMJCJPGHNI) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B01AA0", Offset = "0x2B00AA0", VA = "0x182B01AA0")]
		public void Prefill<T>(T LGELJKPCDJN, int BCCEAMLFENN, [Optional] Action<Component> LFDGEABACFD) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B018B0", Offset = "0x2B008B0", VA = "0x182B018B0")]
		public bool Exists<T>(T LGELJKPCDJN) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B01800", Offset = "0x2B00800", VA = "0x182B01800")]
		public void Clear<T>(T LGELJKPCDJN) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5DB73D0", Offset = "0x5DB63D0", VA = "0x185DB73D0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B01960", Offset = "0x2B00960", VA = "0x182B01960")]
		private HIJGDGKFPDI HDCLKCJIGOH<T>(T LGELJKPCDJN) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		public void TrackInstantiation(string KOGBJPGAFGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		public void EnableStats(bool DELFGBKLLLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7520", Offset = "0x5DB6520", VA = "0x185DB7520")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DB5740", Offset = "0x5DB4740", VA = "0x185DB5740")]
	protected void APGFINKLMNI(Component ODMJCJPGHNI, bool JHLBHCGIPKF, bool GELAHHFEKHP, bool DFNNDCLNIJF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5DB58C0", Offset = "0x5DB48C0", VA = "0x185DB58C0")]
	protected void POOFBCCMBOD(Transform EHIJIKNEIAF, bool JHLBHCGIPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override string AKFKAJPCNFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x35BD030", Offset = "0x35BC030", VA = "0x1835BD030", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override int KFJKNGGDJAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x35BD050", Offset = "0x35BC050", VA = "0x1835BD050", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x35BD5F0", Offset = "0x35BC5F0", VA = "0x1835BD5F0")]
	public CAFOLADMCDF(T LGELJKPCDJN, ObjectPool HFLFKBGDGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x35BD080", Offset = "0x35BC080", VA = "0x1835BD080", Slot = "7")]
	public override void LBNPBPKMGJA(int LGKBEOCJMLG, Action<Component> MOLNFAEIDLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x35BD190", Offset = "0x35BC190", VA = "0x1835BD190", Slot = "8")]
	public override Component LLHBACCELBH(Action<Component> MOLNFAEIDLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x35BCEA0", Offset = "0x35BBEA0", VA = "0x1835BCEA0", Slot = "9")]
	public override bool GCLFHHNKHLO(Component FDEBBPLENLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x35BD400", Offset = "0x35BC400", VA = "0x1835BD400", Slot = "10")]
	public override void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x35BCD40", Offset = "0x35BBD40", VA = "0x1835BCD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DB7000", Offset = "0x5DB6000", VA = "0x185DB7000")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7350", Offset = "0x5DB6350", VA = "0x185DB7350")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DB7690", Offset = "0x5DB6690", VA = "0x185DB7690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5DB75A0", Offset = "0x5DB65A0", VA = "0x185DB75A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5570", Offset = "0x5DB4570", VA = "0x185DB5570")]
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
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
			[Cpp2IlInjected.Address(RVA = "0xD8A2D0", Offset = "0xD892D0", VA = "0x180D8A2D0")]
			public ColorConfiguration(ParticleSystem AKNOJGIBJJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x5DB5290", Offset = "0x5DB4290", VA = "0x185DB5290")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
			[DebuggerHidden]
			public ODFCNPLLJNI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5DB6510", Offset = "0x5DB5510", VA = "0x185DB6510", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5DB6FC0", Offset = "0x5DB5FC0", VA = "0x185DB6FC0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
			[DebuggerHidden]
			public KIFEPIIGDKC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5DB6410", Offset = "0x5DB5410", VA = "0x185DB6410", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5DB64D0", Offset = "0x5DB54D0", VA = "0x185DB64D0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DB87D0", Offset = "0x5DB77D0", VA = "0x185DB87D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ParticleSystem OONLOPDGIJC
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6648E0", Offset = "0x6638E0", VA = "0x1806648E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x68C1C0", Offset = "0x68B1C0", VA = "0x18068C1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ParticleSystem[] BCDACOMNFOG
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6606F0", Offset = "0x65F6F0", VA = "0x1806606F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6E2AE0", Offset = "0x6E1AE0", VA = "0x1806E2AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private ParticleSystemRenderer[] EIBHJEDAOBC
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x651570", Offset = "0x650570", VA = "0x180651570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x651590", Offset = "0x650590", VA = "0x180651590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private MAMGKIJLIOM NMEMEGMIOID
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x72EFF0", Offset = "0x72DFF0", VA = "0x18072EFF0")]
			get
			{
				return default(MAMGKIJLIOM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5DB87B0", Offset = "0x5DB77B0", VA = "0x185DB87B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action LJLOOBDFGPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5DBAAD0", Offset = "0x5DB9AD0", VA = "0x185DBAAD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5DBAB70", Offset = "0x5DB9B70", VA = "0x185DBAB70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA730", Offset = "0x5DB9730", VA = "0x185DBA730")]
		public static PooledParticle TryPlayPrefab(PooledParticle LGELJKPCDJN, Vector3 LPADDFNBONE, Quaternion OIFAPGIKFEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA540", Offset = "0x5DB9540", VA = "0x185DBA540")]
		public static PooledParticle TryPlayPrefab(PooledParticle LGELJKPCDJN, Vector3 LPADDFNBONE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5DB9BB0", Offset = "0x5DB8BB0", VA = "0x185DB9BB0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7F20", Offset = "0x5DB6F20", VA = "0x185DB7F20")]
		private void DIBLIAIJKAG(bool JDGAOKBHEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7FF0", Offset = "0x5DB6FF0", VA = "0x185DB7FF0")]
		[IteratorStateMachine(typeof(ODFCNPLLJNI))]
		private static IEnumerator<KDCGDINMKGL> EPHIACMFAOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5DB88A0", Offset = "0x5DB78A0", VA = "0x185DB88A0")]
		protected void JDIIAMJDBNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8270", Offset = "0x5DB7270", VA = "0x185DB8270")]
		protected void HBKLHEIDCNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7CE0", Offset = "0x5DB6CE0", VA = "0x185DB7CE0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8BD0", Offset = "0x5DB7BD0", VA = "0x185DB8BD0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5DB9120", Offset = "0x5DB8120", VA = "0x185DB9120")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8040", Offset = "0x5DB7040", VA = "0x185DB8040")]
		[IteratorStateMachine(typeof(KIFEPIIGDKC))]
		private IEnumerator<KDCGDINMKGL> FGNJOEGGKFP(float LHKNOFOGOFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB80C0", Offset = "0x5DB70C0", VA = "0x185DB80C0")]
		private void GCLFHHNKHLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA350", Offset = "0x5DB9350", VA = "0x185DBA350")]
		public void SetDuration(float LHKNOFOGOFA, bool OKEKDLKHAOL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5DB9890", Offset = "0x5DB8890", VA = "0x185DB9890")]
		public void Play(Transform KEFMCPDGELC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5DB9270", Offset = "0x5DB8270", VA = "0x185DB9270")]
		public void Play(Transform KEFMCPDGELC, bool MILNOABFKNI, float LHJHMLDMEGB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5DB93C0", Offset = "0x5DB83C0", VA = "0x185DB93C0")]
		public void Play(Transform KEFMCPDGELC, Vector3 CKOLFBHFJIG, bool MILNOABFKNI, float LHJHMLDMEGB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5DB9640", Offset = "0x5DB8640", VA = "0x185DB9640")]
		public void Play(Transform IJFKMLHMNOM, Quaternion OIFAPGIKFEG, bool MILNOABFKNI = false, float LHJHMLDMEGB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5DB9510", Offset = "0x5DB8510", VA = "0x185DB9510")]
		public void Play(Transform IJFKMLHMNOM, Vector3 CKOLFBHFJIG, Quaternion OIFAPGIKFEG, bool MILNOABFKNI = false, float LHJHMLDMEGB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5DB91A0", Offset = "0x5DB81A0", VA = "0x185DB91A0")]
		public void Play(Vector3 LPADDFNBONE, Quaternion OIFAPGIKFEG, Vector3 ICKCINMFDON, bool MILNOABFKNI = false, float LHJHMLDMEGB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5DB99D0", Offset = "0x5DB89D0", VA = "0x185DB99D0")]
		public void Play(Vector3 LPADDFNBONE, Quaternion OIFAPGIKFEG, bool MILNOABFKNI = false, float LHJHMLDMEGB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5DB9780", Offset = "0x5DB8780", VA = "0x185DB9780")]
		public void Play(bool MILNOABFKNI = false, float LHJHMLDMEGB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA4B0", Offset = "0x5DB94B0", VA = "0x185DBA4B0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA420", Offset = "0x5DB9420", VA = "0x185DBA420")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8A40", Offset = "0x5DB7A40", VA = "0x185DB8A40")]
		private void KHAFBJIJNOB(float LHKNOFOGOFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8FB0", Offset = "0x5DB7FB0", VA = "0x185DB8FB0")]
		private void MCAAPLONCEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5DB9A90", Offset = "0x5DB8A90", VA = "0x185DB9A90")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5DB9D50", Offset = "0x5DB8D50", VA = "0x185DB9D50")]
		public void SetColor(Color NNPLNBENDGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8E70", Offset = "0x5DB7E70", VA = "0x185DB8E70")]
		private void MBBMLOJCFGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5DBAA70", Offset = "0x5DB9A70", VA = "0x185DBAA70")]
		public PooledParticle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7FC0", Offset = "0x5DB6FC0", VA = "0x185DB7FC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public BAADKGJHJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4C60", Offset = "0x5DB3C60", VA = "0x185DB4C60")]
	private static string DPBKDPCCPCK(byte[] ENHIJCCJFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4D70", Offset = "0x5DB3D70", VA = "0x185DB4D70")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
