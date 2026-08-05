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
		[Cpp2IlInjected.Address(RVA = "0x57EB9F0", Offset = "0x57EA9F0", VA = "0x1857EB9F0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles DOJHMGHFEFN, float IHFLIIJIPLN, Vector3 IPACGOANALG, Quaternion DJCGMNLFLIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x57EB760", Offset = "0x57EA760", VA = "0x1857EB760")]
		public void SetDamageValue(float IHFLIIJIPLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x57EBB90", Offset = "0x57EAB90", VA = "0x1857EBB90")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MPFIOODNAAH<T> : global::LBHHDEJJNHM<T>, HIOJNGOAMAG, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CLCBLFLIACK<T> : HIOJNGOAMAG, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PHMFBNAAGEO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JMDICMCDJPK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class CNEGKPFEDHG<T> : global::LIMIAHLCBDI<T>, global::MPFIOODNAAH<T>, global::LBHHDEJJNHM<T>, HIOJNGOAMAG, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BKDDIGPGNIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public CNEGKPFEDHG<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
			public BKDDIGPGNIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3D78350", Offset = "0x3D77350", VA = "0x183D78350")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x26D6D30", Offset = "0x26D5D30", VA = "0x1826D6D30")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::DJDAPCKEGEO<T> JHHBKCGOFBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool LOHBFPOMFLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T HBFLGBMAKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool NJLKFAFJNJO;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3D78580", Offset = "0x3D77580", VA = "0x183D78580")]
		public CNEGKPFEDHG(global::DJDAPCKEGEO<T> JHHBKCGOFBA, ObjectPool LOHBFPOMFLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3D78440", Offset = "0x3D77440", VA = "0x183D78440", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class OGFGKPKNNCP<T> : IHDMPJIPDML, global::CLCBLFLIACK<T>, HIOJNGOAMAG, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class AHIODMMBMDE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OGFGKPKNNCP<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
			public AHIODMMBMDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x3D78290", Offset = "0x3D77290", VA = "0x183D78290")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1C52990", Offset = "0x1C51990", VA = "0x181C52990")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private global::DJDAPCKEGEO<T> JHHBKCGOFBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool NJLKFAFJNJO;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3D90300", Offset = "0x3D8F300", VA = "0x183D90300")]
		public OGFGKPKNNCP(global::DJDAPCKEGEO<T> JHHBKCGOFBA, ObjectPool LOHBFPOMFLP, int LPOIEKIDCLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3D902B0", Offset = "0x3D8F2B0", VA = "0x183D902B0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NEABHPCKKBG<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public JMDICMCDJPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::LIMIAHLCBDI<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::DJDAPCKEGEO<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public NEABHPCKKBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D90160", Offset = "0x3D8F160", VA = "0x183D90160")]
		internal void <Exists>b__0(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3D90200", Offset = "0x3D8F200", VA = "0x183D90200")]
		internal void <Exists>b__1(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D90260", Offset = "0x3D8F260", VA = "0x183D90260")]
		internal void <Exists>b__2()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<PHMFBNAAGEO> KGEOJKICEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private CMODJJMMOEE FHJKGBHEEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool LOHBFPOMFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool NJLKFAFJNJO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool ABDBJFJIHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x57EAAA0", Offset = "0x57E9AA0", VA = "0x1857EAAA0")]
	private static void NGKFBPKINKB(Component LIHCFPMBOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x57EAD00", Offset = "0x57E9D00", VA = "0x1857EAD00")]
	public JMDICMCDJPK(string BEKLAGAICMG, int EDOIGNJJKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2609BA0", Offset = "0x2608BA0", VA = "0x182609BA0")]
	public global::MPFIOODNAAH<T> LNDGEOIPPEP<T>(AssetReference OOLPPHOCABG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2385190", Offset = "0x2384190", VA = "0x182385190")]
	public global::CLCBLFLIACK<T> BPKLDHJBPLF<T>(AssetReference OOLPPHOCABG, int FBKJALIBHGM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2064AC0", Offset = "0x2063AC0", VA = "0x182064AC0")]
	public global::LBHHDEJJNHM<bool> EFMFIFBCNEK<T>(AssetReference OOLPPHOCABG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x57EA840", Offset = "0x57E9840", VA = "0x1857EA840", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x57EA710", Offset = "0x57E9710", VA = "0x1857EA710")]
	private void ADHGHLAHAEF(UnityEngine.Object FBJDNBBGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x57EA950", Offset = "0x57E9950", VA = "0x1857EA950")]
	private ObjectPool NBJLKAGLMDP(string BEKLAGAICMG)
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
		private static GlobalPool GJOLDIFNPLC;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject LKPEOKOPKHB;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool CEPBJDBANMN
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x57EA210", Offset = "0x57E9210", VA = "0x1857EA210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x57EA0C0", Offset = "0x57E90C0", VA = "0x1857EA0C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x57EA1A0", Offset = "0x57E91A0", VA = "0x1857EA1A0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, JFMOOBBLFGK> BPOMKFAABKI;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x20C4EA0", Offset = "0x20C3EA0", VA = "0x1820C4EA0")]
		public T Acquire<T>(T DOJHMGHFEFN, [Optional] Action<Component> DLJLOOEIDPL) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x24ECD50", Offset = "0x24EBD50", VA = "0x1824ECD50")]
		public bool Release<T>(T MDAEAKFNGDG) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2443120", Offset = "0x2442120", VA = "0x182443120")]
		public void Prefill<T>(T DOJHMGHFEFN, int OAGCIOFDNBH, [Optional] Action<Component> CJCBHFGPGCB) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x24ECCB0", Offset = "0x24EBCB0", VA = "0x1824ECCB0")]
		public bool Exists<T>(T DOJHMGHFEFN) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2443080", Offset = "0x2442080", VA = "0x182443080")]
		public void Clear<T>(T DOJHMGHFEFN) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x57EB380", Offset = "0x57EA380", VA = "0x1857EB380")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1DDC9C0", Offset = "0x1DDB9C0", VA = "0x181DDC9C0")]
		private JFMOOBBLFGK LEMELOIANBK<T>(T DOJHMGHFEFN) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
		public void TrackInstantiation(string ABILPMJECDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
		public void EnableStats(bool CNDPCDMLEOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x57EA1A0", Offset = "0x57E91A0", VA = "0x1857EA1A0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class JFMOOBBLFGK
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface NCHAOOIBKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EDADIEGOCKE(bool OAGBGICODEG);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract Component BOFPACEBLFO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract string CNNFDLMHGBL
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int LEBJPHHABFE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void BPKLDHJBPLF(int FBKJALIBHGM, Action<Component> CJCBHFGPGCB);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Component LNDGEOIPPEP(Action<Component> DLJLOOEIDPL);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool LNFINCFCIJH(Component MINCEBIIJEG);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void MCOHOPDDOPF();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x57EA3A0", Offset = "0x57E93A0", VA = "0x1857EA3A0")]
	protected void BJCGMPFKOPH(Component MDAEAKFNGDG, bool OAGBGICODEG, bool EGFIOBCNFHD, bool AJBOECCEAOL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x57EA520", Offset = "0x57E9520", VA = "0x1857EA520")]
	protected void NONLIDMEKGE(Transform EJEAOLFLEKF, bool OAGBGICODEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	protected JFMOOBBLFGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LEAHKDIECIO<T> : JFMOOBBLFGK where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T DOJHMGHFEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool DGPKJOGGGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool EGFIOBCNFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> JINIOKNFCJF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Component BOFPACEBLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override string CNNFDLMHGBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x27BEF30", Offset = "0x27BDF30", VA = "0x1827BEF30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override int LEBJPHHABFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x27BEF50", Offset = "0x27BDF50", VA = "0x1827BEF50", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x27BF580", Offset = "0x27BE580", VA = "0x1827BF580")]
	public LEAHKDIECIO(T DOJHMGHFEFN, ObjectPool DGPKJOGGGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x27BECD0", Offset = "0x27BDCD0", VA = "0x1827BECD0", Slot = "7")]
	public override void BPKLDHJBPLF(int FBKJALIBHGM, Action<Component> DLJLOOEIDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x27BEF80", Offset = "0x27BDF80", VA = "0x1827BEF80", Slot = "8")]
	public override Component LNDGEOIPPEP(Action<Component> DLJLOOEIDPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x27BF1B0", Offset = "0x27BE1B0", VA = "0x1827BF1B0", Slot = "9")]
	public override bool LNFINCFCIJH(Component MINCEBIIJEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x27BF340", Offset = "0x27BE340", VA = "0x1827BF340", Slot = "10")]
	public override void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x27BEDE0", Offset = "0x27BDDE0", VA = "0x1827BEDE0")]
	private T CMGIJPCHNMO()
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
		public interface JEKHOAFCJMI
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			GameObject NAMCMDKGPNI
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
		[Cpp2IlInjected.Address(RVA = "0x57EB030", Offset = "0x57EA030", VA = "0x1857EB030")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x57EB310", Offset = "0x57EA310", VA = "0x1857EB310")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool GJOLDIFNPLC;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject LKPEOKOPKHB;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static PersistentGlobalPool CEPBJDBANMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x57EB5A0", Offset = "0x57EA5A0", VA = "0x1857EB5A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x57EB4C0", Offset = "0x57EA4C0", VA = "0x1857EB4C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x57EA1A0", Offset = "0x57E91A0", VA = "0x1857EA1A0")]
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
		public JFMOOBBLFGK PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xEA89A0", Offset = "0xEA79A0", VA = "0x180EA89A0")]
		public PooledObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private enum KPNOHCDLFBJ
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
		public interface LFCOOKHFGKM
		{
			[Cpp2IlInjected.Token(Token = "0x17000010")]
			bool KPOBNKKDMOL
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			Vector3 CBKOAPFIJEP
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			Camera BIPHELDLBIH
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
			[Cpp2IlInjected.Address(RVA = "0xA73C00", Offset = "0xA72C00", VA = "0x180A73C00")]
			public ColorConfiguration(ParticleSystem OCOEJOHAGNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x57E8DF0", Offset = "0x57E7DF0", VA = "0x1857E8DF0")]
			public void NKMICECAOKB(Color IJIJEAAHDCH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class FKOOFOEFEEK : IEnumerator<NGOCCMDJJLC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private NGOCCMDJJLC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private LFCOOKHFGKM <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private NGOCCMDJJLC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6F67D0", Offset = "0x6F57D0", VA = "0x1806F67D0")]
			[DebuggerHidden]
			public FKOOFOEFEEK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x57E95F0", Offset = "0x57E85F0", VA = "0x1857E95F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x57EA070", Offset = "0x57E9070", VA = "0x1857EA070", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class MCBGPIOEFBG : IEnumerator<NGOCCMDJJLC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private NGOCCMDJJLC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private NGOCCMDJJLC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6F67D0", Offset = "0x6F57D0", VA = "0x1806F67D0")]
			[DebuggerHidden]
			public MCBGPIOEFBG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x57EAF20", Offset = "0x57E9F20", VA = "0x1857EAF20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x57EAFE0", Offset = "0x57E9FE0", VA = "0x1857EAFE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> BGAAHEFCOMO;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static List<PooledParticle> AOOICCGLLFL;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static JLELHLFHMNH DJGCLCHMACP;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const float BHBBMPALPPM = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static bool CMDDKIHFLKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		protected int CDAJMNCLKIM;

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
		private ParticleSystem.MinMaxGradient[] KEMDKIIGGOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool JFNIOMGBCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float KNHLHIGNOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float EFOBNPJIMDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Transform FGPJELOJBLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Vector3 BKBEKLFAKCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private Vector3 HHPCONDHBND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private KPNOHCDLFBJ EGCGNKIOEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JLELHLFHMNH HDMDADMANPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		protected bool BEALDBDMPHM;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected static bool DDLIFLFGCBL
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x57EC830", Offset = "0x57EB830", VA = "0x1857EC830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ParticleSystem ALBBDCDBPFN
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x60E0C0", Offset = "0x60D0C0", VA = "0x18060E0C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x709440", Offset = "0x708440", VA = "0x180709440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ParticleSystem[] MMGPHGGAMHP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x60DA30", Offset = "0x60CA30", VA = "0x18060DA30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x71D880", Offset = "0x71C880", VA = "0x18071D880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private ParticleSystemRenderer[] GLAPIGHAGAM
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5E6010", Offset = "0x5E5010", VA = "0x1805E6010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5E6020", Offset = "0x5E5020", VA = "0x1805E6020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private KPNOHCDLFBJ CNCADKPFOPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6B0380", Offset = "0x6AF380", VA = "0x1806B0380")]
			get
			{
				return default(KPNOHCDLFBJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x57ECB00", Offset = "0x57EBB00", VA = "0x1857ECB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action GLJOHLIIBFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x57EE850", Offset = "0x57ED850", VA = "0x1857EE850")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x57EE8F0", Offset = "0x57ED8F0", VA = "0x1857EE8F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x57EE4F0", Offset = "0x57ED4F0", VA = "0x1857EE4F0")]
		public static PooledParticle TryPlayPrefab(PooledParticle DOJHMGHFEFN, Vector3 IPACGOANALG, Quaternion DJCGMNLFLIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x57EE300", Offset = "0x57ED300", VA = "0x1857EE300")]
		public static PooledParticle TryPlayPrefab(PooledParticle DOJHMGHFEFN, Vector3 IPACGOANALG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x57EDB40", Offset = "0x57ECB40", VA = "0x1857EDB40")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x57EBFE0", Offset = "0x57EAFE0", VA = "0x1857EBFE0")]
		private void EDNPCAPHPII(bool CCKFKEMKBMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x57ECE00", Offset = "0x57EBE00", VA = "0x1857ECE00")]
		[IteratorStateMachine(typeof(FKOOFOEFEEK))]
		private static IEnumerator<NGOCCMDJJLC> NLHDBLKNMMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x57EBE60", Offset = "0x57EAE60", VA = "0x1857EBE60")]
		protected void BNJMJINKFLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x57EC210", Offset = "0x57EB210", VA = "0x1857EC210")]
		protected void GBFLBMEGLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x57EBC70", Offset = "0x57EAC70", VA = "0x1857EBC70", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x57ECB20", Offset = "0x57EBB20", VA = "0x1857ECB20")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x57ECE50", Offset = "0x57EBE50", VA = "0x1857ECE50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x57EC8E0", Offset = "0x57EB8E0", VA = "0x1857EC8E0")]
		[IteratorStateMachine(typeof(MCBGPIOEFBG))]
		private IEnumerator<NGOCCMDJJLC> JIAGPKGGDFO(float PHBHMMLJHPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x57EC960", Offset = "0x57EB960", VA = "0x1857EC960")]
		private void LNFINCFCIJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x57EE0E0", Offset = "0x57ED0E0", VA = "0x1857EE0E0")]
		public void SetDuration(float PHBHMMLJHPA, bool KGCOJBLKACE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x57ED8A0", Offset = "0x57EC8A0", VA = "0x1857ED8A0")]
		public void Play(Transform HDBKILHBNKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x57ED710", Offset = "0x57EC710", VA = "0x1857ED710")]
		public void Play(Transform HDBKILHBNKM, bool EJCKDDCGIEH, float HFLKELFLOIL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x57ED380", Offset = "0x57EC380", VA = "0x1857ED380")]
		public void Play(Transform HDBKILHBNKM, Vector3 HHPCONDHBND, bool EJCKDDCGIEH, float HFLKELFLOIL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x57ED130", Offset = "0x57EC130", VA = "0x1857ED130")]
		public void Play(Transform BHMGLJMKGOA, Quaternion DJCGMNLFLIO, bool EJCKDDCGIEH = false, float HFLKELFLOIL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x57ED4D0", Offset = "0x57EC4D0", VA = "0x1857ED4D0")]
		public void Play(Transform BHMGLJMKGOA, Vector3 HHPCONDHBND, Quaternion DJCGMNLFLIO, bool EJCKDDCGIEH = false, float HFLKELFLOIL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x57ED2B0", Offset = "0x57EC2B0", VA = "0x1857ED2B0")]
		public void Play(Vector3 IPACGOANALG, Quaternion DJCGMNLFLIO, Vector3 IJIOEJDIEJF, bool EJCKDDCGIEH = false, float HFLKELFLOIL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x57ED070", Offset = "0x57EC070", VA = "0x1857ED070")]
		public void Play(Vector3 IPACGOANALG, Quaternion DJCGMNLFLIO, bool EJCKDDCGIEH = false, float HFLKELFLOIL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x57ED600", Offset = "0x57EC600", VA = "0x1857ED600")]
		public void Play(bool EJCKDDCGIEH = false, float HFLKELFLOIL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x57EE270", Offset = "0x57ED270", VA = "0x1857EE270")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x57EE1C0", Offset = "0x57ED1C0", VA = "0x1857EE1C0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x57EC090", Offset = "0x57EB090", VA = "0x1857EC090")]
		private void FDAAEPKGPIN(float PHBHMMLJHPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x57EC6C0", Offset = "0x57EB6C0", VA = "0x1857EC6C0")]
		private void GOHLJCANCDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x57EDA20", Offset = "0x57ECA20", VA = "0x1857EDA20")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x57EDCC0", Offset = "0x57ECCC0", VA = "0x1857EDCC0")]
		public void SetColor(Color IJIJEAAHDCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x57ECED0", Offset = "0x57EBED0", VA = "0x1857ECED0")]
		private void PKHMIFACMOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x57EE7C0", Offset = "0x57ED7C0", VA = "0x1857EE7C0")]
		public PooledParticle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x57EC060", Offset = "0x57EB060", VA = "0x1857EC060")]
		[CompilerGenerated]
		private void EGEOOMGHJGD(ParticleSystemRenderer DCNHOJGEJBE)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EJDCELNBKPC
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static byte[] LJMFDKKPNGA;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static int EGAGCALIJCE;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static int AMPJBPFCKBN;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static BigInteger PJENGKNDPGI;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public EJDCELNBKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x57E9000", Offset = "0x57E8000", VA = "0x1857E9000")]
	private static string HACCFPOCPGB(byte[] GMPKOOIGMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x57E9100", Offset = "0x57E8100", VA = "0x1857E9100")]
	public static string NOKDDKHJKOE(byte[] FCLFFFPNPCK, bool DHIAJMPKALJ)
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
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
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
