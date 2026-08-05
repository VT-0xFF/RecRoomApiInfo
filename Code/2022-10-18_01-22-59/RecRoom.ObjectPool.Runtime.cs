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
		[Cpp2IlInjected.Address(RVA = "0x5E07E90", Offset = "0x5E06E90", VA = "0x185E07E90")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles AAICEAICAMA, float DFBMNLNOKPC, Vector3 EIIEKPIPEEF, Quaternion DCNMMHNEEEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5E07C90", Offset = "0x5E06C90", VA = "0x185E07C90")]
		public void SetDamageValue(float DFBMNLNOKPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5E08050", Offset = "0x5E07050", VA = "0x185E08050")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DJKEAPJCJEO<T> : global::DGCAEBAFOOK<T>, NPIGAOPELEF, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ABJGOJANKLG<T> : NPIGAOPELEF, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JPICAIOGMNP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DJFGLHEPMNF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class JGPELPLPEAM<T> : global::BCJEBPCHCFD<T>, global::DJKEAPJCJEO<T>, global::DGCAEBAFOOK<T>, NPIGAOPELEF, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class NCMBPLCCNAI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public JGPELPLPEAM<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
			public NCMBPLCCNAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2FB7260", Offset = "0x2FB6260", VA = "0x182FB7260")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2049CB0", Offset = "0x2048CB0", VA = "0x182049CB0")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::ANFKCNMPPLG<T> PINMFPBMDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool GGGFJPKOCPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T HFEGMKMMHDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool NNFHDNBGFFL;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x34A1F90", Offset = "0x34A0F90", VA = "0x1834A1F90")]
		public JGPELPLPEAM(global::ANFKCNMPPLG<T> PINMFPBMDBB, ObjectPool GGGFJPKOCPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x34A1E50", Offset = "0x34A0E50", VA = "0x1834A1E50", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class OMGALKIKOPB<T> : ENDBBJEPCAJ, global::ABJGOJANKLG<T>, NPIGAOPELEF, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class HDNAMFPHGDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OMGALKIKOPB<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
			public HDNAMFPHGDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2AEBD10", Offset = "0x2AEAD10", VA = "0x182AEBD10")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x15B0D10", Offset = "0x15AFD10", VA = "0x1815B0D10")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private global::ANFKCNMPPLG<T> PINMFPBMDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool NNFHDNBGFFL;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x31F4160", Offset = "0x31F3160", VA = "0x1831F4160")]
		public OMGALKIKOPB(global::ANFKCNMPPLG<T> PINMFPBMDBB, ObjectPool GGGFJPKOCPB, int EJAGIKBOPHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x31F4110", Offset = "0x31F3110", VA = "0x1831F4110", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CAIPCACCBDB<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public DJFGLHEPMNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::BCJEBPCHCFD<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::ANFKCNMPPLG<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
		public CAIPCACCBDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x35D8660", Offset = "0x35D7660", VA = "0x1835D8660")]
		internal void <Exists>b__0(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x35D8700", Offset = "0x35D7700", VA = "0x1835D8700")]
		internal void <Exists>b__1(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x35D8760", Offset = "0x35D7760", VA = "0x1835D8760")]
		internal void <Exists>b__2()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<JPICAIOGMNP> NIAJLKGIHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EJFLOOEODPB INBFEGGEJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool GGGFJPKOCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool AFMKNBKPFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E05C70", Offset = "0x5E04C70", VA = "0x185E05C70")]
	private static void PFKKBCHLFCD(Component AFOPPLDIMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E05F40", Offset = "0x5E04F40", VA = "0x185E05F40")]
	public DJFGLHEPMNF(string NFAIMPDODFD, int ANFCNCNAGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x267F3E0", Offset = "0x267E3E0", VA = "0x18267F3E0")]
	public global::DJKEAPJCJEO<T> FKJKJFLCNLI<T>(AssetReference BDAEKFJAJFM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x267F470", Offset = "0x267E470", VA = "0x18267F470")]
	public global::ABJGOJANKLG<T> MFEEJFIGFIK<T>(AssetReference BDAEKFJAJFM, int KOHJDBBJEKM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x267F020", Offset = "0x267E020", VA = "0x18267F020")]
	public global::DGCAEBAFOOK<bool> AEBBOEKMPNE<T>(AssetReference BDAEKFJAJFM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E05890", Offset = "0x5E04890", VA = "0x185E05890", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E05B30", Offset = "0x5E04B30", VA = "0x185E05B30")]
	private void MOKMNMOBEJM(UnityEngine.Object GEJKEHJBJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E059A0", Offset = "0x5E049A0", VA = "0x185E059A0")]
	private ObjectPool GMIAJFPFIPK(string NFAIMPDODFD)
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
		private static GlobalPool BMDIGDOKCDM;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject PGLKJEIGBKH;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool JNHMLOILMCH
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5E06DD0", Offset = "0x5E05DD0", VA = "0x185E06DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5E06CD0", Offset = "0x5E05CD0", VA = "0x185E06CD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E06DC0", Offset = "0x5E05DC0", VA = "0x185E06DC0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, LADACIFMPNP> PCNOCDOLOFP;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2DED070", Offset = "0x2DEC070", VA = "0x182DED070")]
		public T Acquire<T>(T AAICEAICAMA, [Optional] Action<Component> BMLPOLLCEAI) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2DED400", Offset = "0x2DEC400", VA = "0x182DED400")]
		public bool Release<T>(T CCPIHKCBGHF) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2DED3A0", Offset = "0x2DEC3A0", VA = "0x182DED3A0")]
		public void Prefill<T>(T AAICEAICAMA, int CPINGFEBBCA, [Optional] Action<Component> GNHHOGHIIIA) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2DED1B0", Offset = "0x2DEC1B0", VA = "0x182DED1B0")]
		public bool Exists<T>(T AAICEAICAMA) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2DED100", Offset = "0x2DEC100", VA = "0x182DED100")]
		public void Clear<T>(T AAICEAICAMA) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5E077E0", Offset = "0x5E067E0", VA = "0x185E077E0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2DED260", Offset = "0x2DEC260", VA = "0x182DED260")]
		private LADACIFMPNP JLENKMABNAL<T>(T AAICEAICAMA) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		public void TrackInstantiation(string EOIECJIBGHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		public void EnableStats(bool APCLCGDNPAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5E07930", Offset = "0x5E06930", VA = "0x185E07930")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class LADACIFMPNP
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface NKKFEFKIJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ENDJPLBKPHO(bool CJONJKNGENJ);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract Component KNPKFOEAAOG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract string CKOMIBKPPBC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int JICPIIBLCCP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void MFEEJFIGFIK(int KOHJDBBJEKM, Action<Component> GNHHOGHIIIA);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Component FKJKJFLCNLI(Action<Component> BMLPOLLCEAI);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool LKKBDAMJBBO(Component BNCOECNABPA);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void IIOELKEIHEG();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E07290", Offset = "0x5E06290", VA = "0x185E07290")]
	protected void INMGPENPHAN(Component CCPIHKCBGHF, bool CJONJKNGENJ, bool NBONDEJOOAA, bool JJHPJNMMJHI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5E07090", Offset = "0x5E06090", VA = "0x185E07090")]
	protected void BNDBPBLGNGH(Transform KNEPFPJDKGA, bool CJONJKNGENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	protected LADACIFMPNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GFMFINALPCO<T> : LADACIFMPNP where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T AAICEAICAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool OGPGIEPAPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool NBONDEJOOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> IAELJHHJBFP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Component KNPKFOEAAOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override string CKOMIBKPPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x24E0C80", Offset = "0x24DFC80", VA = "0x1824E0C80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override int JICPIIBLCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x24E0770", Offset = "0x24DF770", VA = "0x1824E0770", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x24E0DB0", Offset = "0x24DFDB0", VA = "0x1824E0DB0")]
	public GFMFINALPCO(T AAICEAICAMA, ObjectPool OGPGIEPAPGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x24E0CA0", Offset = "0x24DFCA0", VA = "0x1824E0CA0", Slot = "7")]
	public override void MFEEJFIGFIK(int KOHJDBBJEKM, Action<Component> BMLPOLLCEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x24E0500", Offset = "0x24DF500", VA = "0x1824E0500", Slot = "8")]
	public override Component FKJKJFLCNLI(Action<Component> BMLPOLLCEAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x24E0AF0", Offset = "0x24DFAF0", VA = "0x1824E0AF0", Slot = "9")]
	public override bool LKKBDAMJBBO(Component BNCOECNABPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x24E0900", Offset = "0x24DF900", VA = "0x1824E0900", Slot = "10")]
	public override void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x24E07A0", Offset = "0x24DF7A0", VA = "0x1824E07A0")]
	private T IIFDJEABELG()
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
		public interface IOIBOLDCPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			GameObject ABFPPGPBDHP
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
		[Cpp2IlInjected.Address(RVA = "0x5E07410", Offset = "0x5E06410", VA = "0x185E07410")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5E07760", Offset = "0x5E06760", VA = "0x185E07760")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool BMDIGDOKCDM;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject PGLKJEIGBKH;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static PersistentGlobalPool JNHMLOILMCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E06AA0", VA = "0x185E07AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5E079B0", Offset = "0x5E069B0", VA = "0x185E079B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5E06DC0", Offset = "0x5E05DC0", VA = "0x185E06DC0")]
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
		public LADACIFMPNP PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xF9D450", Offset = "0xF9C450", VA = "0x180F9D450")]
		public PooledObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private enum JIINPFMDDMC
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
		public interface HNNDPCBENEC
		{
			[Cpp2IlInjected.Token(Token = "0x17000010")]
			bool KHOFLGAIHAG
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			Vector3 BOMKLGADIEC
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			Camera MLAKDKNOOOK
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
			[Cpp2IlInjected.Address(RVA = "0xD7DA40", Offset = "0xD7CA40", VA = "0x180D7DA40")]
			public ColorConfiguration(ParticleSystem NAIDHLLOKIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x5E056A0", Offset = "0x5E046A0", VA = "0x185E056A0")]
			public void APJPECPBBLN(Color OODGAOEPCCI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class GIBIKENHOBD : IEnumerator<BAGIJDLGAMA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private BAGIJDLGAMA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HNNDPCBENEC <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private BAGIJDLGAMA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x65B200", Offset = "0x65A200", VA = "0x18065B200")]
			[DebuggerHidden]
			public GIBIKENHOBD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5E061E0", Offset = "0x5E051E0", VA = "0x185E061E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5E06C90", Offset = "0x5E05C90", VA = "0x185E06C90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class KGKLIHMBPFH : IEnumerator<BAGIJDLGAMA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private BAGIJDLGAMA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private BAGIJDLGAMA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x65B200", Offset = "0x65A200", VA = "0x18065B200")]
			[DebuggerHidden]
			public KGKLIHMBPFH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5E06F90", Offset = "0x5E05F90", VA = "0x185E06F90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5E07050", Offset = "0x5E06050", VA = "0x185E07050", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> LNNHPBEAFBA;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static List<PooledParticle> IBFJJIHGHOL;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static FCEDOONPEIE CMCEGAOLPPB;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const float EKHOFFHPCJF = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static bool EFJBMHIGCGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		protected int FJFBIAHJLBG;

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
		private ParticleSystem.MinMaxGradient[] GKHGMHANKPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool JCBAGANFKDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float AEANMJLKEKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float KNGBLFGDAHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Transform POHNGIPFENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Vector3 HPGGPMIAIAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private Vector3 LCOOINFNBAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private JIINPFMDDMC HLMKGGBCKMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private FCEDOONPEIE JPEKIMEJIJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		protected bool EDPIAMBICJM;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected static bool ONJKJNGENPE
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5E08850", Offset = "0x5E07850", VA = "0x185E08850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ParticleSystem PADMJCAIEBL
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6708E0", VA = "0x1806718E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6991C0", Offset = "0x6981C0", VA = "0x1806991C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ParticleSystem[] FDIANBPKCBA
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C6F0", VA = "0x18066D6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6EFAE0", Offset = "0x6EEAE0", VA = "0x1806EFAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private ParticleSystemRenderer[] EJMNCLBNAOG
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x65E570", Offset = "0x65D570", VA = "0x18065E570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x65E590", Offset = "0x65D590", VA = "0x18065E590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private JIINPFMDDMC LNKEJEAFJJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x73BFF0", Offset = "0x73AFF0", VA = "0x18073BFF0")]
			get
			{
				return default(JIINPFMDDMC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5E08A90", Offset = "0x5E07A90", VA = "0x185E08A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NBBBEPCKBDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5E0AEE0", Offset = "0x5E09EE0", VA = "0x185E0AEE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5E0AF80", Offset = "0x5E09F80", VA = "0x185E0AF80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5E0AB40", Offset = "0x5E09B40", VA = "0x185E0AB40")]
		public static PooledParticle TryPlayPrefab(PooledParticle AAICEAICAMA, Vector3 EIIEKPIPEEF, Quaternion DCNMMHNEEEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5E0A950", Offset = "0x5E09950", VA = "0x185E0A950")]
		public static PooledParticle TryPlayPrefab(PooledParticle AAICEAICAMA, Vector3 EIIEKPIPEEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5E09FC0", Offset = "0x5E08FC0", VA = "0x185E09FC0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5E08F50", Offset = "0x5E07F50", VA = "0x185E08F50")]
		private void NHIHAPLMLHN(bool PDCNOOLALLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5E08AB0", Offset = "0x5E07AB0", VA = "0x185E08AB0")]
		[IteratorStateMachine(typeof(GIBIKENHOBD))]
		private static IEnumerator<BAGIJDLGAMA> LBBIGAFNGJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5E080F0", Offset = "0x5E070F0", VA = "0x185E080F0")]
		protected void AGIOJFEBKLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5E09070", Offset = "0x5E08070", VA = "0x185E09070")]
		protected void PHGLDHEHDKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5E08290", Offset = "0x5E07290", VA = "0x185E08290", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5E08CB0", Offset = "0x5E07CB0", VA = "0x185E08CB0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5E08FF0", Offset = "0x5E07FF0", VA = "0x185E08FF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5E084D0", Offset = "0x5E074D0", VA = "0x185E084D0")]
		[IteratorStateMachine(typeof(KGKLIHMBPFH))]
		private IEnumerator<BAGIJDLGAMA> DFPJCLAFLOJ(float CPFLOLADECM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5E08B00", Offset = "0x5E07B00", VA = "0x185E08B00")]
		private void LKKBDAMJBBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5E0A760", Offset = "0x5E09760", VA = "0x185E0A760")]
		public void SetDuration(float CPFLOLADECM, bool BFEHCMIAFOJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5E09CA0", Offset = "0x5E08CA0", VA = "0x185E09CA0")]
		public void Play(Transform AOKOOHPPFDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5E09680", Offset = "0x5E08680", VA = "0x185E09680")]
		public void Play(Transform AOKOOHPPFDB, bool BLKNKMKAAIK, float HGDMBNDKENN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5E097D0", Offset = "0x5E087D0", VA = "0x185E097D0")]
		public void Play(Transform AOKOOHPPFDB, Vector3 LCOOINFNBAJ, bool BLKNKMKAAIK, float HGDMBNDKENN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5E09A50", Offset = "0x5E08A50", VA = "0x185E09A50")]
		public void Play(Transform CGBHFHMMGIL, Quaternion DCNMMHNEEEM, bool BLKNKMKAAIK = false, float HGDMBNDKENN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5E09920", Offset = "0x5E08920", VA = "0x185E09920")]
		public void Play(Transform CGBHFHMMGIL, Vector3 LCOOINFNBAJ, Quaternion DCNMMHNEEEM, bool BLKNKMKAAIK = false, float HGDMBNDKENN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5E095B0", Offset = "0x5E085B0", VA = "0x185E095B0")]
		public void Play(Vector3 EIIEKPIPEEF, Quaternion DCNMMHNEEEM, Vector3 KEBECJIFKGD, bool BLKNKMKAAIK = false, float HGDMBNDKENN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5E09DE0", Offset = "0x5E08DE0", VA = "0x185E09DE0")]
		public void Play(Vector3 EIIEKPIPEEF, Quaternion DCNMMHNEEEM, bool BLKNKMKAAIK = false, float HGDMBNDKENN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5E09B90", Offset = "0x5E08B90", VA = "0x185E09B90")]
		public void Play(bool BLKNKMKAAIK = false, float HGDMBNDKENN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5E0A8C0", Offset = "0x5E098C0", VA = "0x185E0A8C0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5E0A830", Offset = "0x5E09830", VA = "0x185E0A830")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5E08550", Offset = "0x5E07550", VA = "0x185E08550")]
		private void DMHNHKEBDNE(float CPFLOLADECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5E086E0", Offset = "0x5E076E0", VA = "0x185E086E0")]
		private void DPIPIKAJMAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5E09EA0", Offset = "0x5E08EA0", VA = "0x185E09EA0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5E0A160", Offset = "0x5E09160", VA = "0x185E0A160")]
		public void SetColor(Color OODGAOEPCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5E08950", Offset = "0x5E07950", VA = "0x185E08950")]
		private void ICOKDPFNHNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5E0AE80", Offset = "0x5E09E80", VA = "0x185E0AE80")]
		public PooledParticle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E08920", Offset = "0x5E07920", VA = "0x185E08920")]
		[CompilerGenerated]
		private void IAJJBMKKAFM(ParticleSystemRenderer LOIMAGGBCIJ)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ABAJDIGBNMI
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static byte[] GCDEGNDFAID;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static int BBIOPAKABFB;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static int ACMEFJOAGOE;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static BigInteger MCNKOBABGEE;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public ABAJDIGBNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5E05070", Offset = "0x5E04070", VA = "0x185E05070")]
	private static string DPCKFJIDOBP(byte[] BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5E05180", Offset = "0x5E04180", VA = "0x185E05180")]
	public static string FBACHCLJNPO(byte[] HFAIGCGNPJJ, bool KDMKCCLJMIF)
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
