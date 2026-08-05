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
		[Cpp2IlInjected.Address(RVA = "0x5F69680", Offset = "0x5F68A80", VA = "0x185F69680")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles LPLLOMCCPLH, float FNAKBNDJJHK, Vector3 IAMBOGDEHMB, Quaternion BOMBFPIEJKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5F69480", Offset = "0x5F68880", VA = "0x185F69480")]
		public void SetDamageValue(float FNAKBNDJJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5F69840", Offset = "0x5F68C40", VA = "0x185F69840")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DGKNBIDFABE<T> : global::BHPNOFOGFAO<T>, EEBBFEJKFOP, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ELHIMPIJACD<T> : EEBBFEJKFOP, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DFPNPPEGAGD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DCDPPEMCILH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class IPHNDMFCKMA<T> : global::CABNICEFBOO<T>, global::DGKNBIDFABE<T>, global::BHPNOFOGFAO<T>, EEBBFEJKFOP, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class ENGMDGMPPCI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public IPHNDMFCKMA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
			public ENGMDGMPPCI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x40B7BC0", Offset = "0x40B6FC0", VA = "0x1840B7BC0")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x231D290", Offset = "0x231C690", VA = "0x18231D290")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::JGJKJEIENGF<T> MKCKENDEPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool KBEEBIHEOOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T AEBBMADEDFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool HFPLCOEDAAK;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3211D50", Offset = "0x3211150", VA = "0x183211D50")]
		public IPHNDMFCKMA(global::JGJKJEIENGF<T> MKCKENDEPCO, ObjectPool KBEEBIHEOOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3211C10", Offset = "0x3211010", VA = "0x183211C10", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class EDPHKLFKEFA<T> : ONOPCBLOPNP, global::ELHIMPIJACD<T>, EEBBFEJKFOP, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class HCCHIGMLGLI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public EDPHKLFKEFA<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
			public HCCHIGMLGLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2D93EA0", Offset = "0x2D932A0", VA = "0x182D93EA0")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1174F30", Offset = "0x1174330", VA = "0x181174F30")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private global::JGJKJEIENGF<T> MKCKENDEPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool HFPLCOEDAAK;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28BF8F0", Offset = "0x28BECF0", VA = "0x1828BF8F0")]
		public EDPHKLFKEFA(global::JGJKJEIENGF<T> MKCKENDEPCO, ObjectPool KBEEBIHEOOM, int PAAIEMABMJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28BF8A0", Offset = "0x28BECA0", VA = "0x1828BF8A0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class AGBMCIHAENN<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public DCDPPEMCILH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::CABNICEFBOO<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::JGJKJEIENGF<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public AGBMCIHAENN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2C9CFB0", Offset = "0x2C9C3B0", VA = "0x182C9CFB0")]
		internal void <Exists>b__0(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D050", Offset = "0x2C9C450", VA = "0x182C9D050")]
		internal void <Exists>b__1(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D0B0", Offset = "0x2C9C4B0", VA = "0x182C9D0B0")]
		internal void <Exists>b__2()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<DFPNPPEGAGD> ONIOPLNKJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private NJPOCAJHJJP BBGCMJLDLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool KBEEBIHEOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool HFPLCOEDAAK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool ENDGJHPNKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5F66E30", Offset = "0x5F66230", VA = "0x185F66E30")]
	private static void DKPNAEAKADG(Component NDJEINDKPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5F674E0", Offset = "0x5F668E0", VA = "0x185F674E0")]
	public DCDPPEMCILH(string LFLHOJABIBN, int FIABKADOHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x23C4160", Offset = "0x23C3560", VA = "0x1823C4160")]
	public global::DGKNBIDFABE<T> JBFMKBNAENB<T>(AssetReference MLDIOHBALCI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x23C40B0", Offset = "0x23C34B0", VA = "0x1823C40B0")]
	public global::ELHIMPIJACD<T> ABBFGGBGBGF<T>(AssetReference MLDIOHBALCI, int EFJDLDLIAEL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x23C41F0", Offset = "0x23C35F0", VA = "0x1823C41F0")]
	public global::BHPNOFOGFAO<bool> NNJMHAAKOAN<T>(AssetReference MLDIOHBALCI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5F67080", Offset = "0x5F66480", VA = "0x185F67080", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5F67320", Offset = "0x5F66720", VA = "0x185F67320")]
	private void KDPJLKPLPEO(UnityEngine.Object AIDGJJIKBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5F67190", Offset = "0x5F66590", VA = "0x185F67190")]
	private ObjectPool JGOOEEKLIAI(string LFLHOJABIBN)
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
		private static GlobalPool BLGBDLKAPLN;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject DABLFMGBDGP;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool PNBICMAKACI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5F67880", Offset = "0x5F66C80", VA = "0x185F67880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5F67780", Offset = "0x5F66B80", VA = "0x185F67780")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5F67870", Offset = "0x5F66C70", VA = "0x185F67870")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, LEGOLABAJKN> AMJJADKBNCP;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x27E7910", Offset = "0x27E6D10", VA = "0x1827E7910")]
		public T Acquire<T>(T LPLLOMCCPLH, [Optional] Action<Component> OKPEPHIMGCH) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x27E7CA0", Offset = "0x27E70A0", VA = "0x1827E7CA0")]
		public bool Release<T>(T HKFNIHLBEHC) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x27E7C40", Offset = "0x27E7040", VA = "0x1827E7C40")]
		public void Prefill<T>(T LPLLOMCCPLH, int OFNBNFBIOBA, [Optional] Action<Component> LPAFBNCMEDO) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x27E7A50", Offset = "0x27E6E50", VA = "0x1827E7A50")]
		public bool Exists<T>(T LPLLOMCCPLH) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x27E79A0", Offset = "0x27E6DA0", VA = "0x1827E79A0")]
		public void Clear<T>(T LPLLOMCCPLH) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5F68FD0", Offset = "0x5F683D0", VA = "0x185F68FD0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x27E7B00", Offset = "0x27E6F00", VA = "0x1827E7B00")]
		private LEGOLABAJKN PJNGHNGHEAA<T>(T LPLLOMCCPLH) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		public void TrackInstantiation(string OIOMBBDHLID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		public void EnableStats(bool MGFAOAHEOGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5F69120", Offset = "0x5F68520", VA = "0x185F69120")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class LEGOLABAJKN
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface LMJHIEKNOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BKDEBOFKKDA(bool LBKIMMBOFFC);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract Component CDBCCLOMMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract string AKILJOLADBH
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int AJFGJFKIICG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void ABBFGGBGBGF(int EFJDLDLIAEL, Action<Component> LPAFBNCMEDO);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Component JBFMKBNAENB(Action<Component> OKPEPHIMGCH);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool AEPKJBPFIKJ(Component BDIGDAHEABP);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void HLOEIBCGJID();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5F68A50", Offset = "0x5F67E50", VA = "0x185F68A50")]
	protected void BGBIAGJFPJG(Component HKFNIHLBEHC, bool LBKIMMBOFFC, bool MOCPICGMJKA, bool DIMKANDDBDD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5F68850", Offset = "0x5F67C50", VA = "0x185F68850")]
	protected void BABDEDGNIEC(Transform EACLFGJDCJL, bool LBKIMMBOFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	protected LEGOLABAJKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LGAGLLPMHBE<T> : LEGOLABAJKN where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T LPLLOMCCPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool AFFINNOACDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool MOCPICGMJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> JBDFJBKDODF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Component CDBCCLOMMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override string AKILJOLADBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x23DA700", Offset = "0x23D9B00", VA = "0x1823DA700", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override int AJFGJFKIICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x23DAB80", Offset = "0x23D9F80", VA = "0x1823DAB80", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x23DAD10", Offset = "0x23DA110", VA = "0x1823DAD10")]
	public LGAGLLPMHBE(T LPLLOMCCPLH, ObjectPool AFFINNOACDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x23DA460", Offset = "0x23D9860", VA = "0x1823DA460", Slot = "7")]
	public override void ABBFGGBGBGF(int EFJDLDLIAEL, Action<Component> OKPEPHIMGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x23DA910", Offset = "0x23D9D10", VA = "0x1823DA910", Slot = "8")]
	public override Component JBFMKBNAENB(Action<Component> OKPEPHIMGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x23DA570", Offset = "0x23D9970", VA = "0x1823DA570", Slot = "9")]
	public override bool AEPKJBPFIKJ(Component BDIGDAHEABP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x23DA720", Offset = "0x23D9B20", VA = "0x1823DA720", Slot = "10")]
	public override void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x23DABB0", Offset = "0x23D9FB0", VA = "0x1823DABB0")]
	private T MOHBJGBMHOH()
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
		public interface AMOMOLMKEMD
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			GameObject APKPACOCEIO
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
		[Cpp2IlInjected.Address(RVA = "0x5F68C00", Offset = "0x5F68000", VA = "0x185F68C00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5F68F50", Offset = "0x5F68350", VA = "0x185F68F50")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool BLGBDLKAPLN;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject DABLFMGBDGP;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static PersistentGlobalPool PNBICMAKACI
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5F69290", Offset = "0x5F68690", VA = "0x185F69290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5F691A0", Offset = "0x5F685A0", VA = "0x185F691A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5F67870", Offset = "0x5F66C70", VA = "0x185F67870")]
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
		public LEGOLABAJKN PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F60", Offset = "0xFA9360", VA = "0x180FA9F60")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LNHBJPFLFCN
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int FLDOIHNLNMP(PooledParticle.NGDHGJICOII IBGEACNFOHP);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum FNDKEMIDDDA
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
		public enum NGDHGJICOII
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
		public interface GJLDPMIELLL
		{
			[Cpp2IlInjected.Token(Token = "0x17000015")]
			bool BBMJFEFLOJM
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			Vector3 OLKAPNHLHFG
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			Camera DEMPKAJPIMN
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
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

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD92C60", Offset = "0xD92060", VA = "0x180D92C60")]
			public ColorConfiguration(ParticleSystem KNDHOANBMFJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5F66C40", Offset = "0x5F66040", VA = "0x185F66C40")]
			public void FIOIGOCNJPO(Color GIPDGGFIBAH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class LEKJIGPALBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
			public LEKJIGPALBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5F68BD0", Offset = "0x5F67FD0", VA = "0x185F68BD0")]
			internal void <SetRenderingEnabled>b__0(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class JJFNKKFBDNI : IEnumerator<OJLOAAGJFIF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private OJLOAAGJFIF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private GJLDPMIELLL <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private OJLOAAGJFIF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x671200", Offset = "0x670600", VA = "0x180671200")]
			[DebuggerHidden]
			public JJFNKKFBDNI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5F68170", Offset = "0x5F67570", VA = "0x185F68170", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5F68810", Offset = "0x5F67C10", VA = "0x185F68810", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class JBCKPPDGGJK : IEnumerator<OJLOAAGJFIF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private OJLOAAGJFIF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private OJLOAAGJFIF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x671200", Offset = "0x670600", VA = "0x180671200")]
			[DebuggerHidden]
			public JBCKPPDGGJK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x5F68070", Offset = "0x5F67470", VA = "0x185F68070", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x5F68130", Offset = "0x5F67530", VA = "0x185F68130", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> AKFELLCBIGB;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<LNHBJPFLFCN> NBCAIIFDGDO;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> NAMCMKLOBAM;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static OILBMJAJEOH HJGFNBIPOAL;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float CFHPHMFKGJD = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool LPGKFCELFLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int LJIMPGDGIDP;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private NGDHGJICOII category;

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
		private ParticleSystem.MinMaxGradient[] OFELFBBAOJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool DBNBCPOOGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float IGKNLJCHKFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float GBOFAOFIAGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform BFEKKMIFBGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 CEPGMEFEOMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 ADOMADHHCGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private FNDKEMIDDDA ANHDDGBKNFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private OILBMJAJEOH KCALBBKOMBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool MGNIEDKKGMK;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static IEnumerable<PooledParticle> HIICILPAPIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5F6D130", Offset = "0x5F6C530", VA = "0x185F6D130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public NGDHGJICOII GKANGMLNOEP
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x688C90", Offset = "0x688090", VA = "0x180688C90")]
			get
			{
				return default(NGDHGJICOII);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int HLHOEEFKDID
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x66EBD0", Offset = "0x66DFD0", VA = "0x18066EBD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool ADCMEHCEMMI
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5F6CE20", Offset = "0x5F6C220", VA = "0x185F6CE20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static int KIJKDHPCGEC
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5F6CFB0", Offset = "0x5F6C3B0", VA = "0x185F6CFB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected static bool NNPMOKNEAGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5F6A630", Offset = "0x5F69A30", VA = "0x185F6A630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ParticleSystem IHBBHCDPHIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6878E0", Offset = "0x686CE0", VA = "0x1806878E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6AF1C0", Offset = "0x6AE5C0", VA = "0x1806AF1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ParticleSystem[] GOKPMGHBNNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6836F0", Offset = "0x682AF0", VA = "0x1806836F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x705AE0", Offset = "0x704EE0", VA = "0x180705AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private ParticleSystemRenderer[] FJBPOPNPJHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x674570", Offset = "0x673970", VA = "0x180674570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x674590", Offset = "0x673990", VA = "0x180674590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private FNDKEMIDDDA CKOLACILGPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8133F0", Offset = "0x8127F0", VA = "0x1808133F0")]
			get
			{
				return default(FNDKEMIDDDA);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5F6ACC0", Offset = "0x5F6A0C0", VA = "0x185F6ACC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action AICAMHAKGAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5F6CD80", Offset = "0x5F6C180", VA = "0x185F6CD80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5F6D190", Offset = "0x5F6C590", VA = "0x185F6D190")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5F6C920", Offset = "0x5F6BD20", VA = "0x185F6C920")]
		public static PooledParticle TryPlayPrefab(PooledParticle LPLLOMCCPLH, Vector3 IAMBOGDEHMB, Quaternion BOMBFPIEJKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5F6C730", Offset = "0x5F6BB30", VA = "0x185F6C730")]
		public static PooledParticle TryPlayPrefab(PooledParticle LPLLOMCCPLH, Vector3 IAMBOGDEHMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5F6BDA0", Offset = "0x5F6B1A0", VA = "0x185F6BDA0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5F6A3E0", Offset = "0x5F697E0", VA = "0x185F6A3E0")]
		private void GNJCJACNPJP(bool EFFGBEOGIKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5F6A6C0", Offset = "0x5F69AC0", VA = "0x185F6A6C0")]
		[IteratorStateMachine(typeof(JJFNKKFBDNI))]
		private static IEnumerator<OJLOAAGJFIF> IOEIEGOFLOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5F6A050", Offset = "0x5F69450", VA = "0x185F6A050")]
		private static void GHNOJNJAAMC(Stopwatch PPFBACEKDKI, Vector3 HOHLJGOJDGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5F69E60", Offset = "0x5F69260", VA = "0x185F69E60")]
		private static int FOOBODJHIDG(PooledParticle EIPBHONBEOF, PooledParticle KHDOHMLGMCL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5F69D50", Offset = "0x5F69150", VA = "0x185F69D50")]
		private static int FLDOIHNLNMP(NGDHGJICOII IBGEACNFOHP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5F6B110", Offset = "0x5F6A510", VA = "0x185F6B110")]
		protected void NEGJHLLLPEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5F6A710", Offset = "0x5F69B10", VA = "0x185F6A710")]
		protected void JDCGDBONDFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5F69A90", Offset = "0x5F68E90", VA = "0x185F69A90", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5F6ACE0", Offset = "0x5F6A0E0", VA = "0x185F6ACE0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5F6B310", Offset = "0x5F6A710", VA = "0x185F6B310")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5F69CD0", Offset = "0x5F690D0", VA = "0x185F69CD0")]
		[IteratorStateMachine(typeof(JBCKPPDGGJK))]
		private IEnumerator<OJLOAAGJFIF> EHHDGOFLKKC(float BIOAJJBMPPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5F698E0", Offset = "0x5F68CE0", VA = "0x185F698E0")]
		private void AEPKJBPFIKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5F6C540", Offset = "0x5F6B940", VA = "0x185F6C540")]
		public void SetDuration(float BIOAJJBMPPP, bool AMHNKECKELO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5F6BA80", Offset = "0x5F6AE80", VA = "0x185F6BA80")]
		public void Play(Transform MNENGKFOJHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5F6B460", Offset = "0x5F6A860", VA = "0x185F6B460")]
		public void Play(Transform MNENGKFOJHP, bool GEJFPODLGNJ, float HDFHEOGOGJP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5F6B5B0", Offset = "0x5F6A9B0", VA = "0x185F6B5B0")]
		public void Play(Transform MNENGKFOJHP, Vector3 ADOMADHHCGF, bool GEJFPODLGNJ, float HDFHEOGOGJP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5F6B830", Offset = "0x5F6AC30", VA = "0x185F6B830")]
		public void Play(Transform GEJLLNEPDPN, Quaternion BOMBFPIEJKJ, bool GEJFPODLGNJ = false, float HDFHEOGOGJP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5F6B700", Offset = "0x5F6AB00", VA = "0x185F6B700")]
		public void Play(Transform GEJLLNEPDPN, Vector3 ADOMADHHCGF, Quaternion BOMBFPIEJKJ, bool GEJFPODLGNJ = false, float HDFHEOGOGJP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5F6B390", Offset = "0x5F6A790", VA = "0x185F6B390")]
		public void Play(Vector3 IAMBOGDEHMB, Quaternion BOMBFPIEJKJ, Vector3 CNBICOEGBNM, bool GEJFPODLGNJ = false, float HDFHEOGOGJP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5F6BBC0", Offset = "0x5F6AFC0", VA = "0x185F6BBC0")]
		public void Play(Vector3 IAMBOGDEHMB, Quaternion BOMBFPIEJKJ, bool GEJFPODLGNJ = false, float HDFHEOGOGJP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5F6B970", Offset = "0x5F6AD70", VA = "0x185F6B970")]
		public void Play(bool GEJFPODLGNJ = false, float HDFHEOGOGJP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5F6C6A0", Offset = "0x5F6BAA0", VA = "0x185F6C6A0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5F6C610", Offset = "0x5F6BA10", VA = "0x185F6C610")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5F6AF80", Offset = "0x5F6A380", VA = "0x185F6AF80")]
		private void MDMAHFEPJFK(float BIOAJJBMPPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5F6A4C0", Offset = "0x5F698C0", VA = "0x185F6A4C0")]
		private void HAPDLEGCMFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5F6BC80", Offset = "0x5F6B080", VA = "0x185F6BC80")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5F6BF40", Offset = "0x5F6B340", VA = "0x185F6BF40")]
		public void SetColor(Color GIPDGGFIBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5F69F10", Offset = "0x5F69310", VA = "0x185F69F10")]
		private void GEPBOIMLNEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5F6CD20", Offset = "0x5F6C120", VA = "0x185F6CD20")]
		public PooledParticle()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ILPMCCIAAOO
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static byte[] EFCNCHAHCDJ;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static int IFHOEBNLHGF;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static int CLAMAIDAIOM;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static BigInteger ADBDIIFGHNH;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public ILPMCCIAAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5F67D90", Offset = "0x5F67190", VA = "0x185F67D90")]
	private static string PINDCOCBOMG(byte[] ABBMKKCGFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5F67A40", Offset = "0x5F66E40", VA = "0x185F67A40")]
	public static string OEPGMAKGOND(byte[] OGILIIFBKAD, bool GHCIENBALCN)
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

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
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
