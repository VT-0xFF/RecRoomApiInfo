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
		[Cpp2IlInjected.Address(RVA = "0x5E07430", Offset = "0x5E06230", VA = "0x185E07430")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles AAICEAICAMA, float DFBMNLNOKPC, Vector3 EIIEKPIPEEF, Quaternion DCNMMHNEEEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5E07230", Offset = "0x5E06030", VA = "0x185E07230")]
		public void SetDamageValue(float DFBMNLNOKPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5E075F0", Offset = "0x5E063F0", VA = "0x185E075F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
			public NCMBPLCCNAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2DE1A10", Offset = "0x2DE0810", VA = "0x182DE1A10")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1E71B70", Offset = "0x1E70970", VA = "0x181E71B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x32CCE90", Offset = "0x32CBC90", VA = "0x1832CCE90")]
		public JGPELPLPEAM(global::ANFKCNMPPLG<T> PINMFPBMDBB, ObjectPool GGGFJPKOCPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x32CCD50", Offset = "0x32CBB50", VA = "0x1832CCD50", Slot = "27")]
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
			[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
			public HDNAMFPHGDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2915570", Offset = "0x2914370", VA = "0x182915570")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x13D88D0", Offset = "0x13D76D0", VA = "0x1813D88D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x301EC70", Offset = "0x301DA70", VA = "0x18301EC70")]
		public OMGALKIKOPB(global::ANFKCNMPPLG<T> PINMFPBMDBB, ObjectPool GGGFJPKOCPB, int EJAGIKBOPHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x301EC20", Offset = "0x301DA20", VA = "0x18301EC20", Slot = "19")]
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
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
		public CAIPCACCBDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3403590", Offset = "0x3402390", VA = "0x183403590")]
		internal void <Exists>b__0(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3403630", Offset = "0x3402430", VA = "0x183403630")]
		internal void <Exists>b__1(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3403690", Offset = "0x3402490", VA = "0x183403690")]
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
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E05210", Offset = "0x5E04010", VA = "0x185E05210")]
	private static void PFKKBCHLFCD(Component AFOPPLDIMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E054E0", Offset = "0x5E042E0", VA = "0x185E054E0")]
	public DJFGLHEPMNF(string NFAIMPDODFD, int ANFCNCNAGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x24A7F70", Offset = "0x24A6D70", VA = "0x1824A7F70")]
	public global::DJKEAPJCJEO<T> FKJKJFLCNLI<T>(AssetReference BDAEKFJAJFM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x24A8000", Offset = "0x24A6E00", VA = "0x1824A8000")]
	public global::ABJGOJANKLG<T> MFEEJFIGFIK<T>(AssetReference BDAEKFJAJFM, int KOHJDBBJEKM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x24A7BB0", Offset = "0x24A69B0", VA = "0x1824A7BB0")]
	public global::DGCAEBAFOOK<bool> AEBBOEKMPNE<T>(AssetReference BDAEKFJAJFM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E04E30", Offset = "0x5E03C30", VA = "0x185E04E30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E050D0", Offset = "0x5E03ED0", VA = "0x185E050D0")]
	private void MOKMNMOBEJM(UnityEngine.Object GEJKEHJBJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E04F40", Offset = "0x5E03D40", VA = "0x185E04F40")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E06370", Offset = "0x5E05170", VA = "0x185E06370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5E06270", Offset = "0x5E05070", VA = "0x185E06270")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E06360", Offset = "0x5E05160", VA = "0x185E06360")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C177D0", Offset = "0x2C165D0", VA = "0x182C177D0")]
		public T Acquire<T>(T AAICEAICAMA, [Optional] Action<Component> BMLPOLLCEAI) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2C17B60", Offset = "0x2C16960", VA = "0x182C17B60")]
		public bool Release<T>(T CCPIHKCBGHF) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2C17B00", Offset = "0x2C16900", VA = "0x182C17B00")]
		public void Prefill<T>(T AAICEAICAMA, int CPINGFEBBCA, [Optional] Action<Component> GNHHOGHIIIA) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2C17910", Offset = "0x2C16710", VA = "0x182C17910")]
		public bool Exists<T>(T AAICEAICAMA) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2C17860", Offset = "0x2C16660", VA = "0x182C17860")]
		public void Clear<T>(T AAICEAICAMA) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5E06D80", Offset = "0x5E05B80", VA = "0x185E06D80")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2C179C0", Offset = "0x2C167C0", VA = "0x182C179C0")]
		private LADACIFMPNP JLENKMABNAL<T>(T AAICEAICAMA) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		public void TrackInstantiation(string EOIECJIBGHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		public void EnableStats(bool APCLCGDNPAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5E06ED0", Offset = "0x5E05CD0", VA = "0x185E06ED0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E06830", Offset = "0x5E05630", VA = "0x185E06830")]
	protected void INMGPENPHAN(Component CCPIHKCBGHF, bool CJONJKNGENJ, bool NBONDEJOOAA, bool JJHPJNMMJHI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5E06630", Offset = "0x5E05430", VA = "0x185E06630")]
	protected void BNDBPBLGNGH(Transform KNEPFPJDKGA, bool CJONJKNGENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override string CKOMIBKPPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2309780", Offset = "0x2308580", VA = "0x182309780", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override int JICPIIBLCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2309270", Offset = "0x2308070", VA = "0x182309270", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x23098B0", Offset = "0x23086B0", VA = "0x1823098B0")]
	public GFMFINALPCO(T AAICEAICAMA, ObjectPool OGPGIEPAPGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x23097A0", Offset = "0x23085A0", VA = "0x1823097A0", Slot = "7")]
	public override void MFEEJFIGFIK(int KOHJDBBJEKM, Action<Component> BMLPOLLCEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2309000", Offset = "0x2307E00", VA = "0x182309000", Slot = "8")]
	public override Component FKJKJFLCNLI(Action<Component> BMLPOLLCEAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x23095F0", Offset = "0x23083F0", VA = "0x1823095F0", Slot = "9")]
	public override bool LKKBDAMJBBO(Component BNCOECNABPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2309400", Offset = "0x2308200", VA = "0x182309400", Slot = "10")]
	public override void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x23092A0", Offset = "0x23080A0", VA = "0x1823092A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E069B0", Offset = "0x5E057B0", VA = "0x185E069B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5E06D00", Offset = "0x5E05B00", VA = "0x185E06D00")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E07040", Offset = "0x5E05E40", VA = "0x185E07040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5E06F50", Offset = "0x5E05D50", VA = "0x185E06F50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5E06360", Offset = "0x5E05160", VA = "0x185E06360")]
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
		[Cpp2IlInjected.Address(RVA = "0xDC3F40", Offset = "0xDC2D40", VA = "0x180DC3F40")]
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
			[Cpp2IlInjected.Address(RVA = "0xBD4100", Offset = "0xBD2F00", VA = "0x180BD4100")]
			public ColorConfiguration(ParticleSystem NAIDHLLOKIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x5E04C40", Offset = "0x5E03A40", VA = "0x185E04C40")]
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
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x65B200", Offset = "0x65A000", VA = "0x18065B200")]
			[DebuggerHidden]
			public GIBIKENHOBD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5E05780", Offset = "0x5E04580", VA = "0x185E05780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5E06230", Offset = "0x5E05030", VA = "0x185E06230", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x65B200", Offset = "0x65A000", VA = "0x18065B200")]
			[DebuggerHidden]
			public KGKLIHMBPFH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5E06530", Offset = "0x5E05330", VA = "0x185E06530", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5E065F0", Offset = "0x5E053F0", VA = "0x185E065F0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E07DF0", Offset = "0x5E06BF0", VA = "0x185E07DF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ParticleSystem PADMJCAIEBL
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6706E0", VA = "0x1806718E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6991C0", Offset = "0x697FC0", VA = "0x1806991C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ParticleSystem[] FDIANBPKCBA
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C4F0", VA = "0x18066D6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6EFAE0", Offset = "0x6EE8E0", VA = "0x1806EFAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private ParticleSystemRenderer[] EJMNCLBNAOG
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x65E570", Offset = "0x65D370", VA = "0x18065E570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x65E590", Offset = "0x65D390", VA = "0x18065E590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private JIINPFMDDMC LNKEJEAFJJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x73BFF0", Offset = "0x73ADF0", VA = "0x18073BFF0")]
			get
			{
				return default(JIINPFMDDMC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5E08030", Offset = "0x5E06E30", VA = "0x185E08030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NBBBEPCKBDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5E0A480", Offset = "0x5E09280", VA = "0x185E0A480")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5E0A520", Offset = "0x5E09320", VA = "0x185E0A520")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5E0A0E0", Offset = "0x5E08EE0", VA = "0x185E0A0E0")]
		public static PooledParticle TryPlayPrefab(PooledParticle AAICEAICAMA, Vector3 EIIEKPIPEEF, Quaternion DCNMMHNEEEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5E09EF0", Offset = "0x5E08CF0", VA = "0x185E09EF0")]
		public static PooledParticle TryPlayPrefab(PooledParticle AAICEAICAMA, Vector3 EIIEKPIPEEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5E09560", Offset = "0x5E08360", VA = "0x185E09560")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5E084F0", Offset = "0x5E072F0", VA = "0x185E084F0")]
		private void NHIHAPLMLHN(bool PDCNOOLALLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5E08050", Offset = "0x5E06E50", VA = "0x185E08050")]
		[IteratorStateMachine(typeof(GIBIKENHOBD))]
		private static IEnumerator<BAGIJDLGAMA> LBBIGAFNGJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5E07690", Offset = "0x5E06490", VA = "0x185E07690")]
		protected void AGIOJFEBKLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5E08610", Offset = "0x5E07410", VA = "0x185E08610")]
		protected void PHGLDHEHDKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5E07830", Offset = "0x5E06630", VA = "0x185E07830", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5E08250", Offset = "0x5E07050", VA = "0x185E08250")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5E08590", Offset = "0x5E07390", VA = "0x185E08590")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5E07A70", Offset = "0x5E06870", VA = "0x185E07A70")]
		[IteratorStateMachine(typeof(KGKLIHMBPFH))]
		private IEnumerator<BAGIJDLGAMA> DFPJCLAFLOJ(float CPFLOLADECM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5E080A0", Offset = "0x5E06EA0", VA = "0x185E080A0")]
		private void LKKBDAMJBBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5E09D00", Offset = "0x5E08B00", VA = "0x185E09D00")]
		public void SetDuration(float CPFLOLADECM, bool BFEHCMIAFOJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5E09240", Offset = "0x5E08040", VA = "0x185E09240")]
		public void Play(Transform AOKOOHPPFDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5E08C20", Offset = "0x5E07A20", VA = "0x185E08C20")]
		public void Play(Transform AOKOOHPPFDB, bool BLKNKMKAAIK, float HGDMBNDKENN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5E08D70", Offset = "0x5E07B70", VA = "0x185E08D70")]
		public void Play(Transform AOKOOHPPFDB, Vector3 LCOOINFNBAJ, bool BLKNKMKAAIK, float HGDMBNDKENN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5E08FF0", Offset = "0x5E07DF0", VA = "0x185E08FF0")]
		public void Play(Transform CGBHFHMMGIL, Quaternion DCNMMHNEEEM, bool BLKNKMKAAIK = false, float HGDMBNDKENN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5E08EC0", Offset = "0x5E07CC0", VA = "0x185E08EC0")]
		public void Play(Transform CGBHFHMMGIL, Vector3 LCOOINFNBAJ, Quaternion DCNMMHNEEEM, bool BLKNKMKAAIK = false, float HGDMBNDKENN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5E08B50", Offset = "0x5E07950", VA = "0x185E08B50")]
		public void Play(Vector3 EIIEKPIPEEF, Quaternion DCNMMHNEEEM, Vector3 KEBECJIFKGD, bool BLKNKMKAAIK = false, float HGDMBNDKENN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5E09380", Offset = "0x5E08180", VA = "0x185E09380")]
		public void Play(Vector3 EIIEKPIPEEF, Quaternion DCNMMHNEEEM, bool BLKNKMKAAIK = false, float HGDMBNDKENN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5E09130", Offset = "0x5E07F30", VA = "0x185E09130")]
		public void Play(bool BLKNKMKAAIK = false, float HGDMBNDKENN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5E09E60", Offset = "0x5E08C60", VA = "0x185E09E60")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5E09DD0", Offset = "0x5E08BD0", VA = "0x185E09DD0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5E07AF0", Offset = "0x5E068F0", VA = "0x185E07AF0")]
		private void DMHNHKEBDNE(float CPFLOLADECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5E07C80", Offset = "0x5E06A80", VA = "0x185E07C80")]
		private void DPIPIKAJMAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5E09440", Offset = "0x5E08240", VA = "0x185E09440")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5E09700", Offset = "0x5E08500", VA = "0x185E09700")]
		public void SetColor(Color OODGAOEPCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5E07EF0", Offset = "0x5E06CF0", VA = "0x185E07EF0")]
		private void ICOKDPFNHNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5E0A420", Offset = "0x5E09220", VA = "0x185E0A420")]
		public PooledParticle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E07EC0", Offset = "0x5E06CC0", VA = "0x185E07EC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public ABAJDIGBNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5E04610", Offset = "0x5E03410", VA = "0x185E04610")]
	private static string DPCKFJIDOBP(byte[] BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5E04720", Offset = "0x5E03520", VA = "0x185E04720")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
