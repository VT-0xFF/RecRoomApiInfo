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
		[Header("Impact Particle Start Size")]
		[SerializeField]
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
		[Cpp2IlInjected.Address(RVA = "0x63916B0", Offset = "0x6390AB0", VA = "0x1863916B0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles DFNIHHFOHGC, float HGOJMNCCPAG, Vector3 CJBHLOLHNJP, Quaternion APMJJPLCLEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6391350", Offset = "0x6390750", VA = "0x186391350")]
		public void SetDamageValue(float HGOJMNCCPAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6391830", Offset = "0x6390C30", VA = "0x186391830")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KMGGGDDPLIB<T> : JNFFOANFOAP<T>, PEMLHLMJEJH, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EHOCPOJCIHI<T> : PEMLHLMJEJH, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GCEDIHDOLDI
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DJMNIMJGHCI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class EJJGPKJFHCJ<T> : JPPAJGENKOG<T>, KMGGGDDPLIB<T>, JNFFOANFOAP<T>, PEMLHLMJEJH, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class EGBBMCCPFKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public EJJGPKJFHCJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public EGBBMCCPFKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x33492F0", Offset = "0x33486F0", VA = "0x1833492F0")]
			internal void LHNBKEHCNOJ(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x24A7B80", Offset = "0x24A6F80", VA = "0x1824A7B80")]
			internal void KDPDPGLADGC(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private COOEPIMPOKM<T> CIMFEKOIDLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool PMBHMLBGDMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T DLKEBALDMPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool HFCDDCNLIBB;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x334DFE0", Offset = "0x334D3E0", VA = "0x18334DFE0")]
		public EJJGPKJFHCJ(COOEPIMPOKM<T> CIMFEKOIDLC, ObjectPool PMBHMLBGDMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x334DEA0", Offset = "0x334D2A0", VA = "0x18334DEA0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class JCFFFAPLFMO<T> : IBOPGHHDJFG, EHOCPOJCIHI<T>, PEMLHLMJEJH, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class DHNPANMJPPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public JCFFFAPLFMO<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public DHNPANMJPPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x50F1C30", Offset = "0x50F1030", VA = "0x1850F1C30")]
			internal void LHNBKEHCNOJ(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA468E0", Offset = "0xA45CE0", VA = "0x180A468E0")]
			internal void KDPDPGLADGC(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private COOEPIMPOKM<T> CIMFEKOIDLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool HFCDDCNLIBB;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3B56570", Offset = "0x3B55970", VA = "0x183B56570")]
		public JCFFFAPLFMO(COOEPIMPOKM<T> CIMFEKOIDLC, ObjectPool PMBHMLBGDMO, int PLBFNGMMLLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3B56510", Offset = "0x3B55910", VA = "0x183B56510", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class POCBBLGEEAJ<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public DJMNIMJGHCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public JPPAJGENKOG<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public COOEPIMPOKM<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public POCBBLGEEAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x41BAB20", Offset = "0x41B9F20", VA = "0x1841BAB20")]
		internal void GNJFIGOABNA(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x41BAAC0", Offset = "0x41B9EC0", VA = "0x1841BAAC0")]
		internal void GKDICMCGCGK(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x41BABD0", Offset = "0x41B9FD0", VA = "0x1841BABD0")]
		internal void JHGJFLKIONE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<GCEDIHDOLDI> IHEFEOGOMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private BEEIDILPLAG KGCLDELCLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool PMBHMLBGDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool HFCDDCNLIBB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool EPBBBGDMNPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x638F880", Offset = "0x638EC80", VA = "0x18638F880")]
	private static void NMBDBPPJGCG(Component MGFEBOILECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x638FB50", Offset = "0x638EF50", VA = "0x18638FB50")]
	public DJMNIMJGHCI(string BPMLHPFKFKM, int IDKJMPADCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2663880", Offset = "0x2662C80", VA = "0x182663880")]
	public KMGGGDDPLIB<T> OEJEFNKDECM<T>(AssetReference BLPABDLIGKC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x26637D0", Offset = "0x2662BD0", VA = "0x1826637D0")]
	public EHOCPOJCIHI<T> BLHPHFMDAEI<T>(AssetReference BLPABDLIGKC, int JDBLGKLFJDF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x26633D0", Offset = "0x26627D0", VA = "0x1826633D0")]
	public JNFFOANFOAP<bool> AJPDEGILBCF<T>(AssetReference BLPABDLIGKC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x638F4D0", Offset = "0x638E8D0", VA = "0x18638F4D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x638F750", Offset = "0x638EB50", VA = "0x18638F750")]
	private void KMFHNHHFDHE(UnityEngine.Object BLBLIMJAOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x638F5C0", Offset = "0x638E9C0", VA = "0x18638F5C0")]
	private ObjectPool KCLNBPAHOJP(string BPMLHPFKFKM)
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
		private static GlobalPool BFCHKBMOMAE;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject GHNKBNMHFLD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool GDCHCCJBKDM
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x63902E0", Offset = "0x638F6E0", VA = "0x1863902E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x27F5550", Offset = "0x27F4950", VA = "0x1827F5550")]
		public static void SafeRelease<T>(T LIKEKIACGIL) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6390210", Offset = "0x638F610", VA = "0x186390210")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x63902D0", Offset = "0x638F6D0", VA = "0x1863902D0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, ENLBDFODOKL> IEEIPDLGKHG;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x29564F0", Offset = "0x29558F0", VA = "0x1829564F0")]
		public T Acquire<T>(T DFNIHHFOHGC, [Optional] Action<Component> CGHADBCHELH) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2956720", Offset = "0x2955B20", VA = "0x182956720")]
		public bool Release<T>(T LIKEKIACGIL) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x29566D0", Offset = "0x2955AD0", VA = "0x1829566D0")]
		public void Prefill<T>(T DFNIHHFOHGC, int AFOACJMFCIA, [Optional] Action<Component> DMPADOEPNFH) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2956630", Offset = "0x2955A30", VA = "0x182956630")]
		public bool Exists<T>(T DFNIHHFOHGC) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2956580", Offset = "0x2955980", VA = "0x182956580")]
		public void Clear<T>(T DFNIHHFOHGC) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6390EF0", Offset = "0x63902F0", VA = "0x186390EF0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x29563B0", Offset = "0x29557B0", VA = "0x1829563B0")]
		private ENLBDFODOKL ABKFNCGHOCJ<T>(T DFNIHHFOHGC) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public void TrackInstantiation(string NMPCMDODNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public void EnableStats(bool IMMPPBPOCII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6391060", Offset = "0x6390460", VA = "0x186391060")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class ENLBDFODOKL
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface ALAHIAIJNMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BPNAOMOCGAE(bool JPFJOKPCIEL);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string CGOKMMHCJIB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int PFEFNNHGGIO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void BLHPHFMDAEI(int JDBLGKLFJDF, Action<Component> DMPADOEPNFH);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component OEJEFNKDECM(Action<Component> CGHADBCHELH);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool LBDCCEJODEM(Component MCMEMLEPIDO);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void OIGNPMFKFFL();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6390090", Offset = "0x638F490", VA = "0x186390090")]
	protected void HNBEBNKNADH(Component LIKEKIACGIL, bool JPFJOKPCIEL, bool AGHCPNFGLBJ, bool GMPCLJNCEFN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x638FE10", Offset = "0x638F210", VA = "0x18638FE10")]
	protected void DKPMAOCODAC(Transform IOILNHKHEDM, bool JPFJOKPCIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	protected ENLBDFODOKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NACLGOIIJLI<T> : ENLBDFODOKL where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T DFNIHHFOHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool FNGGEOCJEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool AGHCPNFGLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> ELFIECPKHEF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string CGOKMMHCJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3F67C00", Offset = "0x3F67000", VA = "0x183F67C00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int PFEFNNHGGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3F67D90", Offset = "0x3F67190", VA = "0x183F67D90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3F683C0", Offset = "0x3F677C0", VA = "0x183F683C0")]
	public NACLGOIIJLI(T DFNIHHFOHGC, ObjectPool FNGGEOCJEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3F67AF0", Offset = "0x3F66EF0", VA = "0x183F67AF0", Slot = "6")]
	public override void BLHPHFMDAEI(int JDBLGKLFJDF, Action<Component> CGHADBCHELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3F67F70", Offset = "0x3F67370", VA = "0x183F67F70", Slot = "7")]
	public override Component OEJEFNKDECM(Action<Component> CGHADBCHELH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3F67DD0", Offset = "0x3F671D0", VA = "0x183F67DD0", Slot = "8")]
	public override bool LBDCCEJODEM(Component MCMEMLEPIDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3F681E0", Offset = "0x3F675E0", VA = "0x183F681E0", Slot = "9")]
	public override void OIGNPMFKFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3F67C20", Offset = "0x3F67020", VA = "0x183F67C20")]
	private T FALJALGBAMD()
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
		public interface GABBHHHHDOC
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject FIFPHADJJOL
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6390B70", Offset = "0x638FF70", VA = "0x186390B70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6390E60", Offset = "0x6390260", VA = "0x186390E60")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool BFCHKBMOMAE;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject GHNKBNMHFLD;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool GDCHCCJBKDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x63911B0", Offset = "0x63905B0", VA = "0x1863911B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x63910F0", Offset = "0x63904F0", VA = "0x1863910F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x63902D0", Offset = "0x638F6D0", VA = "0x1863902D0")]
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
		public ENLBDFODOKL PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2F0", Offset = "0x7BC6F0", VA = "0x1807BD2F0")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PMDHDLINDJD
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int OBCOJAIEBOH(PooledParticle.FMMMJHAOPKL KPHKEDLCNEP);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum MAEAHCLOHKJ
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
		public enum FMMMJHAOPKL
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
		public interface LAKLMNIGBAA
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool FCELJOJOBOF
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 GHILLLFIIDO
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera PGPJNNFAJNM
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
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

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x53E9AF0", Offset = "0x53E8EF0", VA = "0x1853E9AF0")]
			public ColorConfiguration(ParticleSystem OKBCHCEIOME)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x638F2E0", Offset = "0x638E6E0", VA = "0x18638F2E0")]
			public void KDNIOPCBKKB(Color MAOKDDLICOE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class DLICENIAFBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public DLICENIAFBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x638FDE0", Offset = "0x638F1E0", VA = "0x18638FDE0")]
			internal void HGBINHDNDEM(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class HKINEHDAPJO : IEnumerator<KIBBKCLDIIA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private KIBBKCLDIIA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private LAKLMNIGBAA <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private KIBBKCLDIIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
			[DebuggerHidden]
			public HKINEHDAPJO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6390450", Offset = "0x638F850", VA = "0x186390450", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6390A60", Offset = "0x638FE60", VA = "0x186390A60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class HMLJHJDFCOE : IEnumerator<KIBBKCLDIIA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private KIBBKCLDIIA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private KIBBKCLDIIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
			[DebuggerHidden]
			public HMLJHJDFCOE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6390AB0", Offset = "0x638FEB0", VA = "0x186390AB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6390B20", Offset = "0x638FF20", VA = "0x186390B20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> MAMJANMAHFD;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<PMDHDLINDJD> EPIJENEAIED;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> ALNIKOFGPEB;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static ELCBICMGPAO DFANPBHCHHM;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float BKGHJLMIIBH = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool CKMOJEOLHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int DHHDDIAMCMO;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private FMMMJHAOPKL category;

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
		private ParticleSystem.MinMaxGradient[] NJGHMHAFMNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool MPCKKFBCAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float KLDPAJFCKPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float LFNNDOFGMJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform MLJGLCPDMIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 JMGNOGIAIGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 IEDEOAEDPLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private MAEAHCLOHKJ MBEKNILGCMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private ELCBICMGPAO FKENIPBBCJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool AHGMCFEBGEL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> JEHMODOHFOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6395080", Offset = "0x6394480", VA = "0x186395080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public FMMMJHAOPKL KOFHHJODOHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7E60B0", Offset = "0x7E54B0", VA = "0x1807E60B0")]
			get
			{
				return default(FMMMJHAOPKL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int OHPNJKPOFKI
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7C55E0", Offset = "0x7C49E0", VA = "0x1807C55E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool GBBOKMIJDDB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6394DB0", Offset = "0x63941B0", VA = "0x186394DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int AMGLPKELEOB
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6394F30", Offset = "0x6394330", VA = "0x186394F30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool NCGJGLHCBNN
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6392520", Offset = "0x6391920", VA = "0x186392520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem FFJKJLDDBHL
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7C1020", Offset = "0x7C0420", VA = "0x1807C1020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A80", Offset = "0x7BFE80", VA = "0x1807C0A80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] NGINIOHPDKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F80", Offset = "0x7C1380", VA = "0x1807C1F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] MIMMNHOFHCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7C46A0", Offset = "0x7C3AA0", VA = "0x1807C46A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private MAEAHCLOHKJ CDBANHOBLMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xEA5010", Offset = "0xEA4410", VA = "0x180EA5010")]
			get
			{
				return default(MAEAHCLOHKJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x63924A0", Offset = "0x63918A0", VA = "0x1863924A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action FOIJEHGEIHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6394D10", Offset = "0x6394110", VA = "0x186394D10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x63950D0", Offset = "0x63944D0", VA = "0x1863950D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x63946A0", Offset = "0x6393AA0", VA = "0x1863946A0")]
		public static PooledParticle TryPlayPrefab(PooledParticle DFNIHHFOHGC, Vector3 CJBHLOLHNJP, Quaternion APMJJPLCLEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6394810", Offset = "0x6393C10", VA = "0x186394810")]
		public static PooledParticle TryPlayPrefab(PooledParticle DFNIHHFOHGC, Vector3 CJBHLOLHNJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6393D50", Offset = "0x6393150", VA = "0x186393D50")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6392240", Offset = "0x6391640", VA = "0x186392240")]
		private void DNLPGJKKHPM(bool BPABDIHDFKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x63924C0", Offset = "0x63918C0", VA = "0x1863924C0")]
		[IteratorStateMachine(typeof(HKINEHDAPJO))]
		private static IEnumerator<KIBBKCLDIIA> GOKHKCAPDEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6391C80", Offset = "0x6391080", VA = "0x186391C80")]
		private static void DCKBGLGKNOP(Stopwatch CBCAJLKKHCH, Vector3 PFNECHMNJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6392060", Offset = "0x6391460", VA = "0x186392060")]
		private static int DEOMLIEJDBF(PooledParticle LCALDLBCJKP, PooledParticle JPKPFNMFEIJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6392F80", Offset = "0x6392380", VA = "0x186392F80")]
		private static int OBCOJAIEBOH(FMMMJHAOPKL KPHKEDLCNEP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6393110", Offset = "0x6392510", VA = "0x186393110")]
		protected void PKNOOPDLEOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6392970", Offset = "0x6391D70", VA = "0x186392970")]
		protected void MLBGBCIAEME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6391910", Offset = "0x6390D10", VA = "0x186391910", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6392700", Offset = "0x6391B00", VA = "0x186392700")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6393090", Offset = "0x6392490", VA = "0x186393090")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6391FD0", Offset = "0x63913D0", VA = "0x186391FD0")]
		[IteratorStateMachine(typeof(HMLJHJDFCOE))]
		private IEnumerator<KIBBKCLDIIA> DCKEMGKKICD(float NBODOCDJMJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x63925A0", Offset = "0x63919A0", VA = "0x1863925A0")]
		private void LBDCCEJODEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x63944B0", Offset = "0x63938B0", VA = "0x1863944B0")]
		public void SetDuration(float NBODOCDJMJC, bool BBEFOAIINDK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6393310", Offset = "0x6392710", VA = "0x186393310")]
		public void Play(Transform CECDMDKPGGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x63939C0", Offset = "0x6392DC0", VA = "0x1863939C0")]
		public void Play(Transform CECDMDKPGGJ, bool OFMPJBEOIBB, float MMHDEIBOCHE = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6393470", Offset = "0x6392870", VA = "0x186393470")]
		public void Play(Transform CECDMDKPGGJ, Vector3 IEDEOAEDPLA, bool OFMPJBEOIBB, float MMHDEIBOCHE = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x63935C0", Offset = "0x63929C0", VA = "0x1863935C0")]
		public void Play(Transform HLBHKCPHDDC, Quaternion APMJJPLCLEP, bool OFMPJBEOIBB = false, float MMHDEIBOCHE = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6393B30", Offset = "0x6392F30", VA = "0x186393B30")]
		public void Play(Transform HLBHKCPHDDC, Vector3 IEDEOAEDPLA, Quaternion APMJJPLCLEP, bool OFMPJBEOIBB = false, float MMHDEIBOCHE = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x63937E0", Offset = "0x6392BE0", VA = "0x1863937E0")]
		public void Play(Vector3 CJBHLOLHNJP, Quaternion APMJJPLCLEP, Vector3 BBCGBJMODNE, bool OFMPJBEOIBB = false, float MMHDEIBOCHE = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6393720", Offset = "0x6392B20", VA = "0x186393720")]
		public void Play(Vector3 CJBHLOLHNJP, Quaternion APMJJPLCLEP, bool OFMPJBEOIBB = false, float MMHDEIBOCHE = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x63938B0", Offset = "0x6392CB0", VA = "0x1863938B0")]
		public void Play(bool OFMPJBEOIBB = false, float MMHDEIBOCHE = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6394610", Offset = "0x6393A10", VA = "0x186394610")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6394580", Offset = "0x6393980", VA = "0x186394580")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6392310", Offset = "0x6391710", VA = "0x186392310")]
		private void GBOEDKEEEGB(float NBODOCDJMJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6391B40", Offset = "0x6390F40", VA = "0x186391B40")]
		private void BMMJGGFILLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6393C60", Offset = "0x6393060", VA = "0x186393C60")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6393ED0", Offset = "0x63932D0", VA = "0x186393ED0")]
		public void SetColor(Color MAOKDDLICOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6392110", Offset = "0x6391510", VA = "0x186392110")]
		private void DIDMFCCPEEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6394C80", Offset = "0x6394080", VA = "0x186394C80")]
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
