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
		[Cpp2IlInjected.Address(RVA = "0x600F060", Offset = "0x600E060", VA = "0x18600F060")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles NEMHBMOBONB, float FFIKAGKGJML, Vector3 LPGLCEHEHMC, Quaternion LGOFCBEILGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x600ED00", Offset = "0x600DD00", VA = "0x18600ED00")]
		public void SetDamageValue(float FFIKAGKGJML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x600F1E0", Offset = "0x600E1E0", VA = "0x18600F1E0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CAGKICGEPOK<T> : FFKFAKMNOMC<T>, LDFABEFGIKK, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HJJGNNPKOKN<T> : LDFABEFGIKK, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NJFIJHKEKKO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MKHCDFALJCI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HDOBKOCJKLE<T> : GJKPNNNIKCG<T>, CAGKICGEPOK<T>, FFKFAKMNOMC<T>, LDFABEFGIKK, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class LLMOHIELLFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public HDOBKOCJKLE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public LLMOHIELLFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3A94EB0", Offset = "0x3A93EB0", VA = "0x183A94EB0")]
			internal void OOPOJJJHBLC(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2E078E0", Offset = "0x2E068E0", VA = "0x182E078E0")]
			internal void EIPCPEHLLJG(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private JFNGNMHHJFA<T> LNECAALGGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool KCFONHLNAPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T PBJLMCDEAOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool BKIGCJKEOGE;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x35EC210", Offset = "0x35EB210", VA = "0x1835EC210")]
		public HDOBKOCJKLE(JFNGNMHHJFA<T> LNECAALGGCM, ObjectPool KCFONHLNAPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x35EC0D0", Offset = "0x35EB0D0", VA = "0x1835EC0D0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class HPAEGNCGBFD<T> : NLHOOGKAONG, HJJGNNPKOKN<T>, LDFABEFGIKK, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class IOGKAHEHLAG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public HPAEGNCGBFD<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public IOGKAHEHLAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x3755270", Offset = "0x3754270", VA = "0x183755270")]
			internal void OOPOJJJHBLC(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x933970", Offset = "0x932970", VA = "0x180933970")]
			internal void EIPCPEHLLJG(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private JFNGNMHHJFA<T> LNECAALGGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool BKIGCJKEOGE;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x36A0280", Offset = "0x369F280", VA = "0x1836A0280")]
		public HPAEGNCGBFD(JFNGNMHHJFA<T> LNECAALGGCM, ObjectPool KCFONHLNAPP, int OMBKDPGGPDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x36A0220", Offset = "0x369F220", VA = "0x1836A0220", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class MCOGGEHJICM<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public MKHCDFALJCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public GJKPNNNIKCG<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public JFNGNMHHJFA<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public MCOGGEHJICM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3C5DC30", Offset = "0x3C5CC30", VA = "0x183C5DC30")]
		internal void NAMAKGALOPC(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3C5DBD0", Offset = "0x3C5CBD0", VA = "0x183C5DBD0")]
		internal void EKFIMGHGIAI(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3C5DCE0", Offset = "0x3C5CCE0", VA = "0x183C5DCE0")]
		internal void OBEIBECNBEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<NJFIJHKEKKO> BGOPALHKLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private NLFONKKAMJC LCAILCCHBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool KCFONHLNAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool BKIGCJKEOGE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool NJLHJFIKGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x600D560", Offset = "0x600C560", VA = "0x18600D560")]
	private static void MEIGIHHPKIC(Component NDABCGGAOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x600D830", Offset = "0x600C830", VA = "0x18600D830")]
	public MKHCDFALJCI(string KHMNDPOMOEK, int MGEKCAKJLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2587120", Offset = "0x2586120", VA = "0x182587120")]
	public CAGKICGEPOK<T> LJOHOPNAHNO<T>(AssetReference MIEHAEGDFPE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2586CE0", Offset = "0x2585CE0", VA = "0x182586CE0")]
	public HJJGNNPKOKN<T> AHOLGBLPLEC<T>(AssetReference MIEHAEGDFPE, int AGLAJIDEGHD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2586D90", Offset = "0x2585D90", VA = "0x182586D90")]
	public FFKFAKMNOMC<bool> AKEJHEAMADO<T>(AssetReference MIEHAEGDFPE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x600D2E0", Offset = "0x600C2E0", VA = "0x18600D2E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x600D1B0", Offset = "0x600C1B0", VA = "0x18600D1B0")]
	private void AHNJHFEEPEJ(UnityEngine.Object NKGKPDJNNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x600D3D0", Offset = "0x600C3D0", VA = "0x18600D3D0")]
	private ObjectPool ILJNLMDEGAI(string KHMNDPOMOEK)
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
		private static GlobalPool NJDDGELCEDO;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject OGKPIBONPFD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool NKFKDADGOPA
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x600D040", Offset = "0x600C040", VA = "0x18600D040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x24F7A70", Offset = "0x24F6A70", VA = "0x1824F7A70")]
		public static void SafeRelease<T>(T GPCHHCACPPJ) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x600CF70", Offset = "0x600BF70", VA = "0x18600CF70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x600D030", Offset = "0x600C030", VA = "0x18600D030")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, OGJHKDODLDE> PLGJFMEENGM;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2639400", Offset = "0x2638400", VA = "0x182639400")]
		public T Acquire<T>(T NEMHBMOBONB, [Optional] Action<Component> EOABMEBGLKM) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2639770", Offset = "0x2638770", VA = "0x182639770")]
		public bool Release<T>(T GPCHHCACPPJ) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2639720", Offset = "0x2638720", VA = "0x182639720")]
		public void Prefill<T>(T NEMHBMOBONB, int FBJKLHMKMJP, [Optional] Action<Component> AHIBMMEEILP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2639540", Offset = "0x2638540", VA = "0x182639540")]
		public bool Exists<T>(T NEMHBMOBONB) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2639490", Offset = "0x2638490", VA = "0x182639490")]
		public void Clear<T>(T NEMHBMOBONB) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x600E240", Offset = "0x600D240", VA = "0x18600E240")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x26395E0", Offset = "0x26385E0", VA = "0x1826395E0")]
		private OGJHKDODLDE IEDOHHBJJHN<T>(T NEMHBMOBONB) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0")]
		public void TrackInstantiation(string LAKNHKJNDMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0")]
		public void EnableStats(bool BFPAMGKOKGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x600E3B0", Offset = "0x600D3B0", VA = "0x18600E3B0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class OGJHKDODLDE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface HMNFNNJKBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MBDOBHGNKLK(bool GFHFKCIIDHH);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string GMOLFEBHJCN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int EBFGHANOOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void AHOLGBLPLEC(int AGLAJIDEGHD, Action<Component> AHIBMMEEILP);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component LJOHOPNAHNO(Action<Component> EOABMEBGLKM);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool FBELCMGCHEP(Component PDBBGMACAPG);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void PMEKKAMOFIE();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x600DAC0", Offset = "0x600CAC0", VA = "0x18600DAC0")]
	protected void BIFEBLLBPEA(Component GPCHHCACPPJ, bool GFHFKCIIDHH, bool PCGCMKDKFHF, bool OFBJEONCOAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x600DC40", Offset = "0x600CC40", VA = "0x18600DC40")]
	protected void LHINDHAOHDF(Transform FIFCFCMOCGG, bool GFHFKCIIDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	protected OGJHKDODLDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LEDCCAIIIEI<T> : OGJHKDODLDE where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T NEMHBMOBONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool ECDPFPCDPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool PCGCMKDKFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> HOPJMOPOEKD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string GMOLFEBHJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3A730C0", Offset = "0x3A720C0", VA = "0x183A730C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int EBFGHANOOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3A73660", Offset = "0x3A72660", VA = "0x183A73660", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3A73880", Offset = "0x3A72880", VA = "0x183A73880")]
	public LEDCCAIIIEI(T NEMHBMOBONB, ObjectPool ECDPFPCDPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3A72FB0", Offset = "0x3A71FB0", VA = "0x183A72FB0", Slot = "6")]
	public override void AHOLGBLPLEC(int AGLAJIDEGHD, Action<Component> EOABMEBGLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3A733F0", Offset = "0x3A723F0", VA = "0x183A733F0", Slot = "7")]
	public override Component LJOHOPNAHNO(Action<Component> EOABMEBGLKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3A73250", Offset = "0x3A72250", VA = "0x183A73250", Slot = "8")]
	public override bool FBELCMGCHEP(Component PDBBGMACAPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3A736A0", Offset = "0x3A726A0", VA = "0x183A736A0", Slot = "9")]
	public override void PMEKKAMOFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3A730E0", Offset = "0x3A720E0", VA = "0x183A730E0")]
	private T EECHHNCDDGJ()
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
		public interface HLBCBCPDCJB
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject KDIEGFLAMBG
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
		[Cpp2IlInjected.Address(RVA = "0x600DEC0", Offset = "0x600CEC0", VA = "0x18600DEC0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x600E1B0", Offset = "0x600D1B0", VA = "0x18600E1B0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool NJDDGELCEDO;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject OGKPIBONPFD;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool NKFKDADGOPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x600EB60", Offset = "0x600DB60", VA = "0x18600EB60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x600EAA0", Offset = "0x600DAA0", VA = "0x18600EAA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x600D030", Offset = "0x600C030", VA = "0x18600D030")]
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
		public OGJHKDODLDE PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x770CA0", Offset = "0x76FCA0", VA = "0x180770CA0")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DIHCFAPNHKD
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JKKPCCKJFMB(PooledParticle.FKFGLOOENDD BCFEHDBCHIE);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum EEBKGBGMHFM
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
		public enum FKFGLOOENDD
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
		public interface DCDOEMKEKHJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool JNBHHLIMHHD
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 CEBMAHDBLCG
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera MENAFBACMIH
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
			[Cpp2IlInjected.Address(RVA = "0x50E3020", Offset = "0x50E2020", VA = "0x1850E3020")]
			public ColorConfiguration(ParticleSystem MCBOPFGAHMD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x600CC90", Offset = "0x600BC90", VA = "0x18600CC90")]
			public void BLHKMJAONPD(Color NGFEKFKHCIJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class DIKDFJAAJLC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public DIKDFJAAJLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x600CE80", Offset = "0x600BE80", VA = "0x18600CE80")]
			internal void OMCBMHLBPPF(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class PHDAKCGKEFN : IEnumerator<DNLJHOFEIAO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private DNLJHOFEIAO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private DCDOEMKEKHJ <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private DNLJHOFEIAO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
			[DebuggerHidden]
			public PHDAKCGKEFN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x600E440", Offset = "0x600D440", VA = "0x18600E440", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x600EA50", Offset = "0x600DA50", VA = "0x18600EA50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class EKJGAHGAIHI : IEnumerator<DNLJHOFEIAO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private DNLJHOFEIAO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private DNLJHOFEIAO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
			[DebuggerHidden]
			public EKJGAHGAIHI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x600CEB0", Offset = "0x600BEB0", VA = "0x18600CEB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x600CF20", Offset = "0x600BF20", VA = "0x18600CF20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> KDFJDFNNMPA;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<DIHCFAPNHKD> FOGEBHPFPIC;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> FAGJOAGDHBG;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static GPGMPFEJBGM OMBCCPNPMPN;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float HKBCJENDIHA = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool GHCFBMMMOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int HGGFGCIMFLJ;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private FKFGLOOENDD category;

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
		private ParticleSystem.MinMaxGradient[] JIBLGHJLIMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool ABLPGLBMDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float FHEKBNEGHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float FPCAJOGGDHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform CLJLIEBNFIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 AEOHONPNBLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 DMIEEKLNGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private EEBKGBGMHFM MHKEJEPPFHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private GPGMPFEJBGM BFBGCOHIJAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool OHGFLOLOKKN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> FJMBKBIDBKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6012A30", Offset = "0x6011A30", VA = "0x186012A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public FKFGLOOENDD PHKIAGCNNOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x798730", Offset = "0x797730", VA = "0x180798730")]
			get
			{
				return default(FKFGLOOENDD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int NIELMNEBNKL
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x775DA0", Offset = "0x774DA0", VA = "0x180775DA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool LODDGFKFEOG
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6012760", Offset = "0x6011760", VA = "0x186012760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int LMMJOCBEMAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x60128E0", Offset = "0x60118E0", VA = "0x1860128E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool GBJCKBCHCDE
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x600F2C0", Offset = "0x600E2C0", VA = "0x18600F2C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem CPFMJLECEEA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x76F1C0", Offset = "0x76E1C0", VA = "0x18076F1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x76F190", Offset = "0x76E190", VA = "0x18076F190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] HFKNCMFMPCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x76F1D0", Offset = "0x76E1D0", VA = "0x18076F1D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x76F220", Offset = "0x76E220", VA = "0x18076F220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] IPABHEMLKJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x774F60", Offset = "0x773F60", VA = "0x180774F60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x774F80", Offset = "0x773F80", VA = "0x180774F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private EEBKGBGMHFM CMNHKPKOBCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xD692D0", Offset = "0xD682D0", VA = "0x180D692D0")]
			get
			{
				return default(EEBKGBGMHFM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x600FFE0", Offset = "0x600EFE0", VA = "0x18600FFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NFKFPKLHGPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x60126C0", Offset = "0x60116C0", VA = "0x1860126C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6012A80", Offset = "0x6011A80", VA = "0x186012A80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6012050", Offset = "0x6011050", VA = "0x186012050")]
		public static PooledParticle TryPlayPrefab(PooledParticle NEMHBMOBONB, Vector3 LPGLCEHEHMC, Quaternion LGOFCBEILGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x60121C0", Offset = "0x60111C0", VA = "0x1860121C0")]
		public static PooledParticle TryPlayPrefab(PooledParticle NEMHBMOBONB, Vector3 LPGLCEHEHMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6011700", Offset = "0x6010700", VA = "0x186011700")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x600FF10", Offset = "0x600EF10", VA = "0x18600FF10")]
		private void DLNMBEIPFAN(bool DNJKBADFLBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6010C60", Offset = "0x600FC60", VA = "0x186010C60")]
		[IteratorStateMachine(typeof(PHDAKCGKEFN))]
		private static IEnumerator<DNLJHOFEIAO> POFCGDDMKIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x60103D0", Offset = "0x600F3D0", VA = "0x1860103D0")]
		private static void INNMNIAFFCE(Stopwatch HCMHKMALPLB, Vector3 NLEKCJBMKKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6010AA0", Offset = "0x600FAA0", VA = "0x186010AA0")]
		private static int MIHHFINHGNJ(PooledParticle LJNLOLDLJAJ, PooledParticle AHGDCNHHAHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6010720", Offset = "0x600F720", VA = "0x186010720")]
		private static int JKKPCCKJFMB(FKFGLOOENDD BCFEHDBCHIE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x600F340", Offset = "0x600E340", VA = "0x18600F340")]
		protected void AIDAAOJINIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x600F770", Offset = "0x600E770", VA = "0x18600F770")]
		protected void DKGINHIOGHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x600F540", Offset = "0x600E540", VA = "0x18600F540", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6010830", Offset = "0x600F830", VA = "0x186010830")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6010BE0", Offset = "0x600FBE0", VA = "0x186010BE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6010B50", Offset = "0x600FB50", VA = "0x186010B50")]
		[IteratorStateMachine(typeof(EKJGAHGAIHI))]
		private IEnumerator<DNLJHOFEIAO> NCEGFJHMBIA(float GNOBHKOCPOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6010140", Offset = "0x600F140", VA = "0x186010140")]
		private void FBELCMGCHEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6011E60", Offset = "0x6010E60", VA = "0x186011E60")]
		public void SetDuration(float GNOBHKOCPOE, bool MNAHFNHLLME = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6010CC0", Offset = "0x600FCC0", VA = "0x186010CC0")]
		public void Play(Transform IAJCDMBLDLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6011370", Offset = "0x6010370", VA = "0x186011370")]
		public void Play(Transform IAJCDMBLDLK, bool BMNPFHJAIGN, float NABNGHJGCGM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6010E20", Offset = "0x600FE20", VA = "0x186010E20")]
		public void Play(Transform IAJCDMBLDLK, Vector3 DMIEEKLNGLE, bool BMNPFHJAIGN, float NABNGHJGCGM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6010F70", Offset = "0x600FF70", VA = "0x186010F70")]
		public void Play(Transform JHNMFECBEDG, Quaternion LGOFCBEILGM, bool BMNPFHJAIGN = false, float NABNGHJGCGM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x60114E0", Offset = "0x60104E0", VA = "0x1860114E0")]
		public void Play(Transform JHNMFECBEDG, Vector3 DMIEEKLNGLE, Quaternion LGOFCBEILGM, bool BMNPFHJAIGN = false, float NABNGHJGCGM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6011190", Offset = "0x6010190", VA = "0x186011190")]
		public void Play(Vector3 LPGLCEHEHMC, Quaternion LGOFCBEILGM, Vector3 OBNDDJFFKOO, bool BMNPFHJAIGN = false, float NABNGHJGCGM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x60110D0", Offset = "0x60100D0", VA = "0x1860110D0")]
		public void Play(Vector3 LPGLCEHEHMC, Quaternion LGOFCBEILGM, bool BMNPFHJAIGN = false, float NABNGHJGCGM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6011260", Offset = "0x6010260", VA = "0x186011260")]
		public void Play(bool BMNPFHJAIGN = false, float NABNGHJGCGM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6011FC0", Offset = "0x6010FC0", VA = "0x186011FC0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6011F30", Offset = "0x6010F30", VA = "0x186011F30")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x600FD80", Offset = "0x600ED80", VA = "0x18600FD80")]
		private void DLMDGHBFHHO(float GNOBHKOCPOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6010000", Offset = "0x600F000", VA = "0x186010000")]
		private void EKFKEOEIDKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6011610", Offset = "0x6010610", VA = "0x186011610")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6011880", Offset = "0x6010880", VA = "0x186011880")]
		public void SetColor(Color NGFEKFKHCIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x60102A0", Offset = "0x600F2A0", VA = "0x1860102A0")]
		private void HEFDHDKAGHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6012630", Offset = "0x6011630", VA = "0x186012630")]
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
