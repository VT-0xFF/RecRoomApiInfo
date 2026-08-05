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
		[Header("Impact Particle System")]
		[SerializeField]
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
		[Header("Impact Particle Start Lifetime")]
		[SerializeField]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Header("Spray Particle System")]
		[SerializeField]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Spray Particle Burst Count")]
		[SerializeField]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6DFBB20", Offset = "0x6DFA120", VA = "0x186DFBB20")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles HLHCNAIOGEN, float ONPOODPBILE, Vector3 LEELMECKGCG, Quaternion JOLHFCINNMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6DFB7C0", Offset = "0x6DF9DC0", VA = "0x186DFB7C0")]
		public void SetDamageValue(float ONPOODPBILE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6DFBCA0", Offset = "0x6DFA2A0", VA = "0x186DFBCA0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EKHFGHKGJPM<T> : JAGIEECCCMP<T>, EOHNLEPDLDE, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GKKPFICBFAD<T> : EOHNLEPDLDE, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NEONBNOOLAH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AJOEEDNDFMG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NHEOIFBMHOK<T> : IFJDAICJPOM<T>, EKHFGHKGJPM<T>, JAGIEECCCMP<T>, EOHNLEPDLDE, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class KEDNHCMJMJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public NHEOIFBMHOK<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public KEDNHCMJMJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4342FE0", Offset = "0x43415E0", VA = "0x184342FE0")]
			internal void KADFCEPNOJB(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x293CD30", Offset = "0x293B330", VA = "0x18293CD30")]
			internal void IFEFHMAMNCA(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private POLPOFEBNLM<T> HOALBHOFHCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool HAPJJBDKDLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T NFEPGHCPILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool HFIMBOHAJFI;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x471C010", Offset = "0x471A610", VA = "0x18471C010")]
		public NHEOIFBMHOK(POLPOFEBNLM<T> HOALBHOFHCN, ObjectPool HAPJJBDKDLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x471BEA0", Offset = "0x471A4A0", VA = "0x18471BEA0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class NKCNNKGMPLH<T> : IKMBNOHICPK, GKKPFICBFAD<T>, EOHNLEPDLDE, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class DJGOABJOCDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public NKCNNKGMPLH<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public DJGOABJOCDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x5A66840", Offset = "0x5A64E40", VA = "0x185A66840")]
			internal void KADFCEPNOJB(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xD3CCD0", Offset = "0xD3B2D0", VA = "0x180D3CCD0")]
			internal void IFEFHMAMNCA(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private POLPOFEBNLM<T> HOALBHOFHCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool HFIMBOHAJFI;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4726C90", Offset = "0x4725290", VA = "0x184726C90")]
		public NKCNNKGMPLH(POLPOFEBNLM<T> HOALBHOFHCN, ObjectPool HAPJJBDKDLK, int DDMGFAMBNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4726C30", Offset = "0x4725230", VA = "0x184726C30", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KBFLKLLPLAM<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AJOEEDNDFMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public IFJDAICJPOM<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public POLPOFEBNLM<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public KBFLKLLPLAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4338A30", Offset = "0x4337030", VA = "0x184338A30")]
		internal void BOAFDGJNNCL(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4338AE0", Offset = "0x43370E0", VA = "0x184338AE0")]
		internal void KJJFNDOBGHO(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4338B40", Offset = "0x4337140", VA = "0x184338B40")]
		internal void MGANHGLKDFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<NEONBNOOLAH> ENDBILDBLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private PKMEDFOCAIO KECPLNDDGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool HAPJJBDKDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool HFIMBOHAJFI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6DF9B20", Offset = "0x6DF8120", VA = "0x186DF9B20")]
	private static void EPHNGKJOKGC(Component INEJDODHNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6DF9DF0", Offset = "0x6DF83F0", VA = "0x186DF9DF0")]
	public AJOEEDNDFMG(string MANKBKONOGI, int BBBICFEFIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x334CAF0", Offset = "0x334B0F0", VA = "0x18334CAF0")]
	public EKHFGHKGJPM<T> KINKNPKFCGM<T>(AssetReference DJMKOFAAMFK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x334CBC0", Offset = "0x334B1C0", VA = "0x18334CBC0")]
	public GKKPFICBFAD<T> PIPNKHNABPP<T>(AssetReference DJMKOFAAMFK, int FIGHABPEBPG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x334C6C0", Offset = "0x334ACC0", VA = "0x18334C6C0")]
	public JAGIEECCCMP<bool> AOOFMIHDJBB<T>(AssetReference DJMKOFAAMFK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6DF9A30", Offset = "0x6DF8030", VA = "0x186DF9A30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6DF9900", Offset = "0x6DF7F00", VA = "0x186DF9900")]
	private void ABIFNAKJNED(UnityEngine.Object HDLEADJBJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6DF9770", Offset = "0x6DF7D70", VA = "0x186DF9770")]
	private ObjectPool AADNMNOBNOB(string MANKBKONOGI)
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
		private static GlobalPool MBANBAPHHHD;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject EGEAOICEOOM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool DFEEMNKDOMA
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6DFAE80", Offset = "0x6DF9480", VA = "0x186DFAE80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2CCE970", Offset = "0x2CCCF70", VA = "0x182CCE970")]
		public static void SafeRelease<T>(T GHMNBJIOGAM) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6DFADB0", Offset = "0x6DF93B0", VA = "0x186DFADB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6DFAE70", Offset = "0x6DF9470", VA = "0x186DFAE70")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, EFAKGCHJGJK> NODLALJNHPH;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2E574E0", Offset = "0x2E55AE0", VA = "0x182E574E0")]
		public T Acquire<T>(T HLHCNAIOGEN, [Optional] Action<Component> JKDBLCBOGAP) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2E578A0", Offset = "0x2E55EA0", VA = "0x182E578A0")]
		public bool Release<T>(T GHMNBJIOGAM) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2E57830", Offset = "0x2E55E30", VA = "0x182E57830")]
		public void Prefill<T>(T HLHCNAIOGEN, int CHFEHHGMJLD, [Optional] Action<Component> BOFLHCEBDOM) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2E57650", Offset = "0x2E55C50", VA = "0x182E57650")]
		public bool Exists<T>(T HLHCNAIOGEN) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2E575A0", Offset = "0x2E55BA0", VA = "0x182E575A0")]
		public void Clear<T>(T HLHCNAIOGEN) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6DFB380", Offset = "0x6DF9980", VA = "0x186DFB380")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2E576F0", Offset = "0x2E55CF0", VA = "0x182E576F0")]
		private EFAKGCHJGJK IKOALEIBLLJ<T>(T HLHCNAIOGEN) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
		public void TrackInstantiation(string NCOKAKAMKAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
		public void EnableStats(bool NONKHHGKFEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6DFB4F0", Offset = "0x6DF9AF0", VA = "0x186DFB4F0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class EFAKGCHJGJK
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface BAMPAHANABO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CMJJOJFHFCI(bool OPPPLDKFPNA);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int NDLFNIMEHKM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void PIPNKHNABPP(int FIGHABPEBPG, Action<Component> BOFLHCEBDOM);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component KINKNPKFCGM(Action<Component> JKDBLCBOGAP);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool CJCAMEPPGCI(Component FJNDKHIIOLD);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void MPAAPCHGDCP();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6DFA8F0", Offset = "0x6DF8EF0", VA = "0x186DFA8F0")]
	protected void IFLGJJBOHLM(Component GHMNBJIOGAM, bool OPPPLDKFPNA, bool HPAFOKKDCND, bool CAABIKJLJFL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6DFAA70", Offset = "0x6DF9070", VA = "0x186DFAA70")]
	protected void LMPOKDIPAAL(Transform DFGOMOHCFAM, bool OPPPLDKFPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	protected EFAKGCHJGJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class OHGIEEFOGCB<T> : EFAKGCHJGJK where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T HLHCNAIOGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool JGJONCALMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool HPAFOKKDCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> EEELNCOAFCM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4823A70", Offset = "0x4822070", VA = "0x184823A70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int NDLFNIMEHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x48236D0", Offset = "0x4821CD0", VA = "0x1848236D0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4824060", Offset = "0x4822660", VA = "0x184824060")]
	public OHGIEEFOGCB(T HLHCNAIOGEN, ObjectPool JGJONCALMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4823F30", Offset = "0x4822530", VA = "0x184823F30", Slot = "6")]
	public override void PIPNKHNABPP(int FIGHABPEBPG, Action<Component> JKDBLCBOGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4823A90", Offset = "0x4822090", VA = "0x184823A90", Slot = "7")]
	public override Component KINKNPKFCGM(Action<Component> JKDBLCBOGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4823730", Offset = "0x4821D30", VA = "0x184823730", Slot = "8")]
	public override bool CJCAMEPPGCI(Component FJNDKHIIOLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4823D20", Offset = "0x4822320", VA = "0x184823D20", Slot = "9")]
	public override void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x48238F0", Offset = "0x4821EF0", VA = "0x1848238F0")]
	private T HPLLPLICNGI()
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
		public interface KANJOLIFMGK
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject FPHLOHPEDGG
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
		[Cpp2IlInjected.Address(RVA = "0x6DFB000", Offset = "0x6DF9600", VA = "0x186DFB000")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6DFB2F0", Offset = "0x6DF98F0", VA = "0x186DFB2F0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool MBANBAPHHHD;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject EGEAOICEOOM;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool DFEEMNKDOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6DFB640", Offset = "0x6DF9C40", VA = "0x186DFB640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6DFB580", Offset = "0x6DF9B80", VA = "0x186DFB580")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6DFAE70", Offset = "0x6DF9470", VA = "0x186DFAE70")]
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
		public EFAKGCHJGJK PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x885340", Offset = "0x883940", VA = "0x180885340")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CIOFPNDPJCL
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NAMPGMDHCGP(PooledParticle.OEMAPMHJEKH PDMFFKPECJB);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum PEFAPLBMCMC
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
		public enum OEMAPMHJEKH
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
		public interface CDBDCOLFCGE
		{
			[Cpp2IlInjected.Token(Token = "0x17000012")]
			bool FNKNPNKODAA
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			Vector3 FHCNDAEICCJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Camera GKKDLJCCILE
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
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

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5D26CB0", Offset = "0x5D252B0", VA = "0x185D26CB0")]
			public ColorConfiguration(ParticleSystem AEALNKNNNAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6DFA700", Offset = "0x6DF8D00", VA = "0x186DFA700")]
			public void IBNHEHMKGEM(Color FEHNKBJAMFH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class LJPGFHJLMNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public LJPGFHJLMNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6DFAFD0", Offset = "0x6DF95D0", VA = "0x186DFAFD0")]
			internal void MMJODJEGBNG(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class BHMCCCGBFCP : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private GJDHNIMFMOA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private CDBDCOLFCGE <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
			[DebuggerHidden]
			public BHMCCCGBFCP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6DFA080", Offset = "0x6DF8680", VA = "0x186DFA080", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6DFA6B0", Offset = "0x6DF8CB0", VA = "0x186DFA6B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class GNBJLHGLDAK : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private GJDHNIMFMOA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
			[DebuggerHidden]
			public GNBJLHGLDAK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6DFACF0", Offset = "0x6DF92F0", VA = "0x186DFACF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6DFAD60", Offset = "0x6DF9360", VA = "0x186DFAD60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> IEKJHGKKHDN;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<CIOFPNDPJCL> AHIMGLGKHEO;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> EHDHAANOMCC;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static EPGCCCKMEBG MNCPJKKADHP;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float LBCGLLLJEOP = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool PKFDAKFBDON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int EANIDGCLMHC;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private OEMAPMHJEKH category;

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
		private ParticleSystem.MinMaxGradient[] AIILDICHAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool IELCIHJFCPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float KOBKOFNNCPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float GOIGGICHGHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform OGGGOKFFAKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 GHHCFDJDDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 NGAOCNNAIKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private PEFAPLBMCMC JPCPAJFBMNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private EPGCCCKMEBG FBENIAIOAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool CNAMDINLHBO;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> NPHHEPAPEPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6DFF470", Offset = "0x6DFDA70", VA = "0x186DFF470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public OEMAPMHJEKH DKDFJNHPABB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8ADCB0", Offset = "0x8AC2B0", VA = "0x1808ADCB0")]
			get
			{
				return default(OEMAPMHJEKH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int LBCEHIJGMBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x88D660", Offset = "0x88BC60", VA = "0x18088D660")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GCCFAKHHEJA
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6DFF1B0", Offset = "0x6DFD7B0", VA = "0x186DFF1B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int BLJBONOGCJA
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6DFF320", Offset = "0x6DFD920", VA = "0x186DFF320")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool LKLDCINHFGC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6DFD130", Offset = "0x6DFB730", VA = "0x186DFD130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem EGIEIPDOAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8860F0", VA = "0x180887AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x88B6B0", Offset = "0x889CB0", VA = "0x18088B6B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] MAODJJPBLHE
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8879A0", Offset = "0x885FA0", VA = "0x1808879A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x88B6A0", Offset = "0x889CA0", VA = "0x18088B6A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] JHFFDGAENOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8879F0", Offset = "0x885FF0", VA = "0x1808879F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x887AB0", Offset = "0x8860B0", VA = "0x180887AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private PEFAPLBMCMC EOCJKHJKEDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x11AE4E0", Offset = "0x11ACAE0", VA = "0x1811AE4E0")]
			get
			{
				return default(PEFAPLBMCMC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6DFD320", Offset = "0x6DFB920", VA = "0x186DFD320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action HMDBDNAKABE
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6DFF110", Offset = "0x6DFD710", VA = "0x186DFF110")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6DFF4C0", Offset = "0x6DFDAC0", VA = "0x186DFF4C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6DFEAD0", Offset = "0x6DFD0D0", VA = "0x186DFEAD0")]
		public static PooledParticle TryPlayPrefab(PooledParticle HLHCNAIOGEN, Vector3 LEELMECKGCG, Quaternion JOLHFCINNMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6DFEC40", Offset = "0x6DFD240", VA = "0x186DFEC40")]
		public static PooledParticle TryPlayPrefab(PooledParticle HLHCNAIOGEN, Vector3 LEELMECKGCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6DFE180", Offset = "0x6DFC780", VA = "0x186DFE180")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6DFC730", Offset = "0x6DFAD30", VA = "0x186DFC730")]
		private void GGMKDILGPGE(bool BDGDGHAINAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6DFD2C0", Offset = "0x6DFB8C0", VA = "0x186DFD2C0")]
		[IteratorStateMachine(typeof(BHMCCCGBFCP))]
		private static IEnumerator<GJDHNIMFMOA> NLAKBLCGHDP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6DFC0F0", Offset = "0x6DFA6F0", VA = "0x186DFC0F0")]
		private static void DBIEKCEBJFB(Stopwatch LOIGOPGNFFM, Vector3 INLPMFLMNPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE10", Offset = "0x6DFB410", VA = "0x186DFCE10")]
		private static int JPPDNIPLDNL(PooledParticle JDKMLCHPKLA, PooledParticle AENKMLMFBAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6DFD1B0", Offset = "0x6DFB7B0", VA = "0x186DFD1B0")]
		private static int NAMPGMDHCGP(OEMAPMHJEKH PDMFFKPECJB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6DFD340", Offset = "0x6DFB940", VA = "0x186DFD340")]
		protected void OLEDBFHDGEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6DFC800", Offset = "0x6DFAE00", VA = "0x186DFC800")]
		protected void JGPBCMMHDBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6DFBD70", Offset = "0x6DFA370", VA = "0x186DFBD70", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCEC0", Offset = "0x6DFB4C0", VA = "0x186DFCEC0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6DFD530", Offset = "0x6DFBB30", VA = "0x186DFD530")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6DFC560", Offset = "0x6DFAB60", VA = "0x186DFC560")]
		[IteratorStateMachine(typeof(GNBJLHGLDAK))]
		private IEnumerator<GJDHNIMFMOA> GDNLDACJBON(float MCPPIEMELEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6DFBF90", Offset = "0x6DFA590", VA = "0x186DFBF90")]
		private void CJCAMEPPGCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6DFE8E0", Offset = "0x6DFCEE0", VA = "0x186DFE8E0")]
		public void SetDuration(float MCPPIEMELEJ, bool KDEAKPDPBNC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6DFD740", Offset = "0x6DFBD40", VA = "0x186DFD740")]
		public void Play(Transform DMNOIODALIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6DFDDF0", Offset = "0x6DFC3F0", VA = "0x186DFDDF0")]
		public void Play(Transform DMNOIODALIN, bool BJIHBDEGANF, float CKJKJCIMLFK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6DFD8A0", Offset = "0x6DFBEA0", VA = "0x186DFD8A0")]
		public void Play(Transform DMNOIODALIN, Vector3 NGAOCNNAIKF, bool BJIHBDEGANF, float CKJKJCIMLFK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6DFD9F0", Offset = "0x6DFBFF0", VA = "0x186DFD9F0")]
		public void Play(Transform KKDGGBLEEEF, Quaternion JOLHFCINNMA, bool BJIHBDEGANF = false, float CKJKJCIMLFK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6DFDF60", Offset = "0x6DFC560", VA = "0x186DFDF60")]
		public void Play(Transform KKDGGBLEEEF, Vector3 NGAOCNNAIKF, Quaternion JOLHFCINNMA, bool BJIHBDEGANF = false, float CKJKJCIMLFK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6DFDC10", Offset = "0x6DFC210", VA = "0x186DFDC10")]
		public void Play(Vector3 LEELMECKGCG, Quaternion JOLHFCINNMA, Vector3 DLPEMGFGHPD, bool BJIHBDEGANF = false, float CKJKJCIMLFK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6DFDB50", Offset = "0x6DFC150", VA = "0x186DFDB50")]
		public void Play(Vector3 LEELMECKGCG, Quaternion JOLHFCINNMA, bool BJIHBDEGANF = false, float CKJKJCIMLFK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6DFDCE0", Offset = "0x6DFC2E0", VA = "0x186DFDCE0")]
		public void Play(bool BJIHBDEGANF = false, float CKJKJCIMLFK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6DFEA40", Offset = "0x6DFD040", VA = "0x186DFEA40")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6DFE9B0", Offset = "0x6DFCFB0", VA = "0x186DFE9B0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6DFD5B0", Offset = "0x6DFBBB0", VA = "0x186DFD5B0")]
		private void PHHNKPMGPIE(float MCPPIEMELEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6DFC5F0", Offset = "0x6DFABF0", VA = "0x186DFC5F0")]
		private void GFMBPEBCDEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6DFE090", Offset = "0x6DFC690", VA = "0x186DFE090")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6DFE300", Offset = "0x6DFC900", VA = "0x186DFE300")]
		public void SetColor(Color FEHNKBJAMFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6DFC430", Offset = "0x6DFAA30", VA = "0x186DFC430")]
		private void DDJHINCHOFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6DFF080", Offset = "0x6DFD680", VA = "0x186DFF080")]
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
