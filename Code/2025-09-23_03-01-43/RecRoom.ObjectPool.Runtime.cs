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
		[Cpp2IlInjected.Address(RVA = "0x88B7560", Offset = "0x88B5B60", VA = "0x1888B7560")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles IKHBLDCGHAN, float BBCEHJAFJAE, Vector3 APHHGJIDDCM, Quaternion LDAEEKEKDJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x88B7200", Offset = "0x88B5800", VA = "0x1888B7200")]
		public void SetDamageValue(float BBCEHJAFJAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88B76A0", Offset = "0x88B5CA0", VA = "0x1888B76A0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OIIIIBJEEBC<T> : EEOEHGFNDGC<T>, FBCJGBABFLH, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EGEBFIHCNBK<T> : FBCJGBABFLH, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HLCCMMFNIHF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MKODNEDAKPJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class LPPEBIFKINN<T> : CLJOKGFDDAD<T>, OIIIIBJEEBC<T>, EEOEHGFNDGC<T>, FBCJGBABFLH, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class HOGHNIEEKOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public LPPEBIFKINN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public HOGHNIEEKOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x517F8D0", Offset = "0x517DED0", VA = "0x18517F8D0")]
			internal void KJLMOGFJHPI(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x433B0A0", Offset = "0x43396A0", VA = "0x18433B0A0")]
			internal void ICKGOIOHGOE(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private OFBDOHFHPFI<T> EDNKNBEPPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool EJNOGMMAEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T MHKMPBAHOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool AJNGKKLNKMJ;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x57F3980", Offset = "0x57F1F80", VA = "0x1857F3980")]
		public LPPEBIFKINN(OFBDOHFHPFI<T> EDNKNBEPPCD, ObjectPool EJNOGMMAEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x57F3840", Offset = "0x57F1E40", VA = "0x1857F3840", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class KEEAOPMIPMN<T> : PGEMBGNKGNP, EGEBFIHCNBK<T>, FBCJGBABFLH, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class BADNKAELBPF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public KEEAOPMIPMN<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public BADNKAELBPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6A02AA0", Offset = "0x6A010A0", VA = "0x186A02AA0")]
			internal void KJLMOGFJHPI(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x1735B20", Offset = "0x1734120", VA = "0x181735B20")]
			internal void ICKGOIOHGOE(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private OFBDOHFHPFI<T> EDNKNBEPPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool AJNGKKLNKMJ;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x55E6700", Offset = "0x55E4D00", VA = "0x1855E6700")]
		public KEEAOPMIPMN(OFBDOHFHPFI<T> EDNKNBEPPCD, ObjectPool EJNOGMMAEGA, int HEIKLFMIOIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x55E66A0", Offset = "0x55E4CA0", VA = "0x1855E66A0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DGJNNLJDFHA<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public MKODNEDAKPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public CLJOKGFDDAD<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public OFBDOHFHPFI<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public DGJNNLJDFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x465A4A0", Offset = "0x4658AA0", VA = "0x18465A4A0")]
		internal void EBKEFOACOPO(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x465A440", Offset = "0x4658A40", VA = "0x18465A440")]
		internal void EACFIBBGPEE(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x465A550", Offset = "0x4658B50", VA = "0x18465A550")]
		internal void NJMCCBLOIEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<HLCCMMFNIHF> KNBBHPNABGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private KGEIKNHKCEE KPONBPDBEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool EJNOGMMAEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool AJNGKKLNKMJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x88B60E0", Offset = "0x88B46E0", VA = "0x1888B60E0")]
	private static void CFDBFOHLDKM(Component IDFKPPKNONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x88B6790", Offset = "0x88B4D90", VA = "0x1888B6790")]
	public MKODNEDAKPJ(string ICGKKCLOGHP, int FEBJFCOMAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3ED8640", Offset = "0x3ED6C40", VA = "0x183ED8640")]
	public OIIIIBJEEBC<T> NPAODEBCNPN<T>(AssetReference CKJJAGAEKPB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3ED8590", Offset = "0x3ED6B90", VA = "0x183ED8590")]
	public EGEBFIHCNBK<T> KLOCCOKPDNE<T>(AssetReference CKJJAGAEKPB, int LMJBLNOIBOL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3ED8130", Offset = "0x3ED6730", VA = "0x183ED8130")]
	public EEOEHGFNDGC<bool> CCCINLIBFDH<T>(AssetReference CKJJAGAEKPB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x88B6330", Offset = "0x88B4930", VA = "0x1888B6330", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x88B65B0", Offset = "0x88B4BB0", VA = "0x1888B65B0")]
	private void HMNMBKCLEOA(UnityEngine.Object MIJCADJIHEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x88B6420", Offset = "0x88B4A20", VA = "0x1888B6420")]
	private ObjectPool HKEAPCHOFJO(string ICGKKCLOGHP)
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
		private static GlobalPool BICCGKMJHOH;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject JKFFJMHKDBB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool EHBCEBDHHPE
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x88B54F0", Offset = "0x88B3AF0", VA = "0x1888B54F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6780", Offset = "0x3DE4D80", VA = "0x183DE6780")]
		public static void SafeRelease<T>(T MPIDDJPOOMJ) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x88B5420", Offset = "0x88B3A20", VA = "0x1888B5420")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88B54E0", Offset = "0x88B3AE0", VA = "0x1888B54E0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct OFLBKFACDOC<T> : IDisposable where T : Component
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly T GDIPECPNBIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private readonly ObjectPool BHPJDAFOMDP;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public T CECIKJNPCJO
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xC5DA70", Offset = "0xC5C070", VA = "0x180C5DA70")]
			internal OFLBKFACDOC(T KOPHBHGIACG, ObjectPool BHPJDAFOMDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5BAC1D0", Offset = "0x5BAA7D0", VA = "0x185BAC1D0", Slot = "4")]
			void IDisposable.Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, KPGFEIJOJNL> NGHOCICBJIB;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3F88220", Offset = "0x3F86820", VA = "0x183F88220")]
		public T Acquire<T>(T IKHBLDCGHAN, [Optional] Action<Component> EOFMHOPBIME) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3F881A0", Offset = "0x3F867A0", VA = "0x183F881A0")]
		public OFLBKFACDOC<T> AcquirePooledObject<T>(T IKHBLDCGHAN, [Optional] Action<Component> EOFMHOPBIME) where T : Component
		{
			return default(OFLBKFACDOC<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3F88590", Offset = "0x3F86B90", VA = "0x183F88590")]
		public bool Release<T>(T MPIDDJPOOMJ) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3F88540", Offset = "0x3F86B40", VA = "0x183F88540")]
		public void Prefill<T>(T IKHBLDCGHAN, int FLMCKCFKGNG, [Optional] Action<Component> FOIGENBPAAH) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3F88360", Offset = "0x3F86960", VA = "0x183F88360")]
		public bool Exists<T>(T IKHBLDCGHAN) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3F882B0", Offset = "0x3F868B0", VA = "0x183F882B0")]
		public void Clear<T>(T IKHBLDCGHAN) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x88B6DA0", Offset = "0x88B53A0", VA = "0x1888B6DA0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3F88400", Offset = "0x3F86A00", VA = "0x183F88400")]
		private KPGFEIJOJNL FEFNDIKEBMI<T>(T IKHBLDCGHAN) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public void TrackInstantiation(string BNFPPKJBLFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public void EnableStats(bool FACKDKFAHLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x88B6F10", Offset = "0x88B5510", VA = "0x1888B6F10")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class KPGFEIJOJNL
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface PPLCFPKFCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NKDHHDLNINP(bool KAHLPNCEPBM);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string EEABAFMMHKN
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int PPKDOGKACMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void KLOCCOKPDNE(int LMJBLNOIBOL, Action<Component> FOIGENBPAAH);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component NPAODEBCNPN(Action<Component> EOFMHOPBIME);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool AMPHLDINMDF(Component DDCCCNLJKEF);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void ELFNJAKNOMA();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x88B5F60", Offset = "0x88B4560", VA = "0x1888B5F60")]
	protected void DHILJPOGOKH(Component MPIDDJPOOMJ, bool KAHLPNCEPBM, bool FPEAGELPHKB, bool NDGBIFLENIP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x88B5CE0", Offset = "0x88B42E0", VA = "0x1888B5CE0")]
	protected void BCHGCHEHKAG(Transform CJHOFIEGLPJ, bool KAHLPNCEPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	protected KPGFEIJOJNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ODPBIFCACDD<T> : KPGFEIJOJNL where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private T IKHBLDCGHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private ObjectPool NFNPLPJKCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool FPEAGELPHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Queue<T> BIBGGOMPFBA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string EEABAFMMHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5BAA090", Offset = "0x5BA8690", VA = "0x185BAA090", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int PPKDOGKACMG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5BAA5E0", Offset = "0x5BA8BE0", VA = "0x185BAA5E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5BAA620", Offset = "0x5BA8C20", VA = "0x185BAA620")]
	public ODPBIFCACDD(T IKHBLDCGHAN, ObjectPool NFNPLPJKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5BAA0B0", Offset = "0x5BA86B0", VA = "0x185BAA0B0", Slot = "6")]
	public override void KLOCCOKPDNE(int LMJBLNOIBOL, Action<Component> EOFMHOPBIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5BAA1C0", Offset = "0x5BA87C0", VA = "0x185BAA1C0", Slot = "7")]
	public override Component NPAODEBCNPN(Action<Component> EOFMHOPBIME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5BA9D00", Offset = "0x5BA8300", VA = "0x185BA9D00", Slot = "8")]
	public override bool AMPHLDINMDF(Component DDCCCNLJKEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5BA9EA0", Offset = "0x5BA84A0", VA = "0x185BA9EA0", Slot = "9")]
	public override void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5BAA430", Offset = "0x5BA8A30", VA = "0x185BAA430")]
	private T ODDKCMOICCD()
	{
		return null;
	}
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class ObjectPoolPreFill : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct PrefillDataEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Component prefab;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public int numInstances;
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public interface HLJKLCIAIDJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject NNKCBHNLPFB
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x88B6A20", Offset = "0x88B5020", VA = "0x1888B6A20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x88B6D10", Offset = "0x88B5310", VA = "0x1888B6D10")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static PersistentGlobalPool BICCGKMJHOH;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static GameObject JKFFJMHKDBB;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool EHBCEBDHHPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x88B7060", Offset = "0x88B5660", VA = "0x1888B7060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x88B6FA0", Offset = "0x88B55A0", VA = "0x1888B6FA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x88B54E0", Offset = "0x88B3AE0", VA = "0x1888B54E0")]
		public PersistentGlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class PooledObject : MonoBehaviour
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public KPGFEIJOJNL PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HAABEIMJNIF
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int FJGDPKCHPDD(PooledParticle.LNKKEGLGPJG OKIBPDDCDLN);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private enum INMOJJPJIID
		{
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum LNKKEGLGPJG
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public interface DOEJKAAKMCG
		{
			[Cpp2IlInjected.Token(Token = "0x17000014")]
			bool LBHALGDEAFI
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Vector3 FKDPDAIOCJN
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			Camera GNGMAJHKGEK
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class ColorConfiguration
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x742C340", Offset = "0x742A940", VA = "0x18742C340")]
			public ColorConfiguration(ParticleSystem KNHLOFFAIPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x88B5200", Offset = "0x88B3800", VA = "0x1888B5200")]
			public void FIJOGNHJBOJ(Color FPHNLEHIJEM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class FIFIKJLIKEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public FIFIKJLIKEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x88B53F0", Offset = "0x88B39F0", VA = "0x1888B53F0")]
			internal void EBIGNJLIKMD(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class IIJFPLEBFML : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private KAIBAKBEOHB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private DOEJKAAKMCG <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public IIJFPLEBFML(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x88B5660", Offset = "0x88B3C60", VA = "0x1888B5660", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x88B5C90", Offset = "0x88B4290", VA = "0x1888B5C90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> IGDOGKJMNPA;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Lazy<HAABEIMJNIF> PBHCMOFNCKM;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static List<PooledParticle> BBIHAFKJCEK;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static FAKIPBKLGEB PAEDNPFBJFG;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const float KPGJOELALIO = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static bool DBOOIJMKJOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected int ECGCJMFGJFH;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private LNKKEGLGPJG category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private float? DPLJAFBJBDD;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private ParticleSystem.MinMaxGradient[] LOFDKOMCJNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private ParticleSystem.MinMaxGradient[] MPGKHAJNJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool DNGKICLOMFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private float HDFCHGHLNHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private float KNJNGOGBDBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Transform CNOHAKLBFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Vector3 EMJEDDOCDEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 BEBEGIMMLMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private INMOJJPJIID JDCJDCIPHBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private FAKIPBKLGEB NHGIOFGNEHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		protected bool LPNBAIALJFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private Transform GKMKOPPOHCE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> GJJNIODJCMH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x88BB1D0", Offset = "0x88B97D0", VA = "0x1888BB1D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public LNKKEGLGPJG KMGBCMKCLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xACF420", Offset = "0xACDA20", VA = "0x180ACF420")]
			get
			{
				return default(LNKKEGLGPJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int BJKFIMLKKBH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool CEILCAIBNDN
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x88BAF00", Offset = "0x88B9500", VA = "0x1888BAF00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int ILAPCEFLPFB
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x88BB080", Offset = "0x88B9680", VA = "0x1888BB080")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool JOCGNJAGAOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x88B8610", Offset = "0x88B6C10", VA = "0x1888B8610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem DBKBJPECDPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAA9ED0", Offset = "0xAA84D0", VA = "0x180AA9ED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] AGJCOKKNLHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAB2A30", Offset = "0xAB1030", VA = "0x180AB2A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] MNJDGIJBEDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAA56F0", Offset = "0xAA3CF0", VA = "0x180AA56F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private INMOJJPJIID JHPGIMKPFLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xF66CA0", Offset = "0xF652A0", VA = "0x180F66CA0")]
			get
			{
				return default(INMOJJPJIID);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x88B82D0", Offset = "0x88B68D0", VA = "0x1888B82D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Transform CCHLCEHOKAD
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x88BB220", Offset = "0x88B9820", VA = "0x1888BB220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action FJAKOGCJDLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x88BAE60", Offset = "0x88B9460", VA = "0x1888BAE60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x88BB270", Offset = "0x88B9870", VA = "0x1888BB270")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x88BA870", Offset = "0x88B8E70", VA = "0x1888BA870")]
		public static PooledParticle TryPlayPrefab(PooledParticle IKHBLDCGHAN, Vector3 APHHGJIDDCM, Quaternion LDAEEKEKDJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x88BA990", Offset = "0x88B8F90", VA = "0x1888BA990")]
		public static PooledParticle TryPlayPrefab(PooledParticle IKHBLDCGHAN, Vector3 APHHGJIDDCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x88B9FD0", Offset = "0x88B85D0", VA = "0x1888B9FD0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x88B86F0", Offset = "0x88B6CF0", VA = "0x1888B86F0")]
		private void JPNAPGCAFNJ(bool ALDDDKDADPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x88B8690", Offset = "0x88B6C90", VA = "0x1888B8690")]
		[IteratorStateMachine(typeof(IIJFPLEBFML))]
		private static IEnumerator<KAIBAKBEOHB> ILFLJCIMMLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x88B8BA0", Offset = "0x88B71A0", VA = "0x1888B8BA0")]
		private static void MEJNCJJPIFD(Stopwatch PGBOBMDDLFM, Vector3 KNDKNGJFECH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x88B87C0", Offset = "0x88B6DC0", VA = "0x1888B87C0")]
		private static int KNCJGEFBEAB(PooledParticle BNPLNGPMIIG, PooledParticle DIIGMDFDOAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x88B8500", Offset = "0x88B6B00", VA = "0x1888B8500")]
		private static int FJGDPKCHPDD(LNKKEGLGPJG OKIBPDDCDLN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x88B90B0", Offset = "0x88B76B0", VA = "0x1888B90B0")]
		protected void OCAFKILPEFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x88B7CC0", Offset = "0x88B62C0", VA = "0x1888B7CC0")]
		protected void BHJHGOBJFBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x88B7A40", Offset = "0x88B6040", VA = "0x1888B7A40", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x88B8870", Offset = "0x88B6E70", VA = "0x1888B8870")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x88B92A0", Offset = "0x88B78A0", VA = "0x1888B92A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x88B7840", Offset = "0x88B5E40", VA = "0x1888B7840")]
		private void AMPHLDINMDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x88BA600", Offset = "0x88B8C00", VA = "0x1888BA600")]
		public void SetDuration(float KFCMKNFBLHC, bool ILKEMCIBDMC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x88B9330", Offset = "0x88B7930", VA = "0x1888B9330")]
		public void Play(Transform JAECCFDJGIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x88B9BA0", Offset = "0x88B81A0", VA = "0x1888B9BA0")]
		public void Play(Transform JAECCFDJGIG, bool CJOOOFKABBO, float OLABIJDECBG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x88B9490", Offset = "0x88B7A90", VA = "0x1888B9490")]
		public void Play(Transform JAECCFDJGIG, Vector3 BEBEGIMMLMN, bool CJOOOFKABBO, float OLABIJDECBG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x88B95E0", Offset = "0x88B7BE0", VA = "0x1888B95E0")]
		public void Play(Transform BJDANNJONEJ, Quaternion LDAEEKEKDJC, bool CJOOOFKABBO = false, float OLABIJDECBG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x88B9D10", Offset = "0x88B8310", VA = "0x1888B9D10")]
		public void Play(Transform BJDANNJONEJ, Vector3 BEBEGIMMLMN, Quaternion LDAEEKEKDJC, bool CJOOOFKABBO = false, float OLABIJDECBG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x88B9880", Offset = "0x88B7E80", VA = "0x1888B9880")]
		public void Play(Vector3 APHHGJIDDCM, Quaternion LDAEEKEKDJC, Vector3 EJLBFNGBOJC, bool CJOOOFKABBO = false, float OLABIJDECBG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x88B9720", Offset = "0x88B7D20", VA = "0x1888B9720")]
		public void Play(Vector3 APHHGJIDDCM, Quaternion LDAEEKEKDJC, bool CJOOOFKABBO = false, float OLABIJDECBG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x88B9A00", Offset = "0x88B8000", VA = "0x1888B9A00")]
		public void Play(bool CJOOOFKABBO = false, float OLABIJDECBG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x88BA7D0", Offset = "0x88B8DD0", VA = "0x1888BA7D0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x88BA6D0", Offset = "0x88B8CD0", VA = "0x1888BA6D0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x88B82F0", Offset = "0x88B68F0", VA = "0x1888B82F0")]
		private void BMOBELHGIIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x88B9E40", Offset = "0x88B8440", VA = "0x1888B9E40")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x88BA150", Offset = "0x88B8750", VA = "0x1888BA150")]
		public void SetColor(Color FPHNLEHIJEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x88B7780", Offset = "0x88B5D80", VA = "0x1888B7780")]
		private void ABOGOIECBEK(float? HBAPMMDKJDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x88B9040", Offset = "0x88B7640", VA = "0x1888B9040")]
		private void NJMINLMAHLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x88B8F10", Offset = "0x88B7510", VA = "0x1888B8F10")]
		private void NCJLOKNBGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x88BADC0", Offset = "0x88B93C0", VA = "0x1888BADC0")]
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
