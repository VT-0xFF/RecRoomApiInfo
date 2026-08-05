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
		[Cpp2IlInjected.Address(RVA = "0x602FDF0", Offset = "0x602E9F0", VA = "0x18602FDF0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles NMGALPBKFJN, float KIGEPEKBIDL, Vector3 CFCLFCDKKPD, Quaternion HFKFMHAMLPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x602FA90", Offset = "0x602E690", VA = "0x18602FA90")]
		public void SetDamageValue(float KIGEPEKBIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x602FF70", Offset = "0x602EB70", VA = "0x18602FF70")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GDGMNGKPNNC<T> : HPJLJGHAIKN<T>, CKPENFELBCE, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MBBHCNCMJDC<T> : CKPENFELBCE, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AMEGJFHIAOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DMBKLBEOMHI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class IEMMGGBMJBK<T> : KNCNIEDDCNP<T>, GDGMNGKPNNC<T>, HPJLJGHAIKN<T>, CKPENFELBCE, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IJPNHHEHONH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public IEMMGGBMJBK<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public IJPNHHEHONH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x373D360", Offset = "0x373BF60", VA = "0x18373D360")]
			internal void JBJBGKEPCGL(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2D2F400", Offset = "0x2D2E000", VA = "0x182D2F400")]
			internal void DJHNABNBEJI(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private CFFLLKAPPEH<T> OBLEJOGPBHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool IPBHFFFPPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T BJMIJNLECJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool MFJFBBMDDII;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3713560", Offset = "0x3712160", VA = "0x183713560")]
		public IEMMGGBMJBK(CFFLLKAPPEH<T> OBLEJOGPBHG, ObjectPool IPBHFFFPPLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3713420", Offset = "0x3712020", VA = "0x183713420", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class AHCECAEPDPM<T> : EEHJIENCILF, MBBHCNCMJDC<T>, CKPENFELBCE, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class CJMPBMIKFND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public AHCECAEPDPM<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public CJMPBMIKFND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x4B335E0", Offset = "0x4B321E0", VA = "0x184B335E0")]
			internal void JBJBGKEPCGL(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x96B840", Offset = "0x96A440", VA = "0x18096B840")]
			internal void DJHNABNBEJI(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private CFFLLKAPPEH<T> OBLEJOGPBHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool MFJFBBMDDII;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x35F4780", Offset = "0x35F3380", VA = "0x1835F4780")]
		public AHCECAEPDPM(CFFLLKAPPEH<T> OBLEJOGPBHG, ObjectPool IPBHFFFPPLB, int CHINKKLFMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x35F4720", Offset = "0x35F3320", VA = "0x1835F4720", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GHHAGPCMLHG<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public DMBKLBEOMHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public KNCNIEDDCNP<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CFFLLKAPPEH<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public GHHAGPCMLHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x35BB630", Offset = "0x35BA230", VA = "0x1835BB630")]
		internal void PNIHFFNLKJH(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x35BB580", Offset = "0x35BA180", VA = "0x1835BB580")]
		internal void INJADBADPKN(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x35BB5E0", Offset = "0x35BA1E0", VA = "0x1835BB5E0")]
		internal void KNODIHFMIJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<AMEGJFHIAOJ> FNBEHCKEFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private HOIILOFEDAH NCPNNGBPLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool IPBHFFFPPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool MFJFBBMDDII;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool NLHPPEHGHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x602E730", Offset = "0x602D330", VA = "0x18602E730")]
	private static void DMCADMALOBK(Component FNLDGAFEDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x602EDB0", Offset = "0x602D9B0", VA = "0x18602EDB0")]
	public DMBKLBEOMHI(string BBODCMJFAEN, int AGNFDIFAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2387500", Offset = "0x2386100", VA = "0x182387500")]
	public GDGMNGKPNNC<T> EPNOJHHKCNC<T>(AssetReference ABKIJBNMAML) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2387190", Offset = "0x2385D90", VA = "0x182387190")]
	public MBBHCNCMJDC<T> BIPOFLGKHMN<T>(AssetReference ABKIJBNMAML, int EMHEDPDPEMP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2387240", Offset = "0x2385E40", VA = "0x182387240")]
	public HPJLJGHAIKN<bool> ENKHGCDGNNP<T>(AssetReference ABKIJBNMAML) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x602E970", Offset = "0x602D570", VA = "0x18602E970", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x602EA60", Offset = "0x602D660", VA = "0x18602EA60")]
	private void EOPJJEBPBDF(UnityEngine.Object LGNDGJHKOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x602EB90", Offset = "0x602D790", VA = "0x18602EB90")]
	private ObjectPool LDKPCGDEHBC(string BBODCMJFAEN)
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
		private static GlobalPool GGGHPJBNGCE;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject MBJHKHOBEJO;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool IDAIJJLMAFB
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x602F110", Offset = "0x602DD10", VA = "0x18602F110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x24FE8E0", Offset = "0x24FD4E0", VA = "0x1824FE8E0")]
		public static void SafeRelease<T>(T IIFJCGIHMIN) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x602F040", Offset = "0x602DC40", VA = "0x18602F040")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x602F100", Offset = "0x602DD00", VA = "0x18602F100")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, AJJDCOMNPCE> HKPBOJBFKCJ;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2657EF0", Offset = "0x2656AF0", VA = "0x182657EF0")]
		public T Acquire<T>(T NMGALPBKFJN, [Optional] Action<Component> CPDMHIECMAE) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2658260", Offset = "0x2656E60", VA = "0x182658260")]
		public bool Release<T>(T IIFJCGIHMIN) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2658210", Offset = "0x2656E10", VA = "0x182658210")]
		public void Prefill<T>(T NMGALPBKFJN, int PCIIAGHAHKJ, [Optional] Action<Component> IGPPEIBJIDI) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2658170", Offset = "0x2656D70", VA = "0x182658170")]
		public bool Exists<T>(T NMGALPBKFJN) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x26580C0", Offset = "0x2656CC0", VA = "0x1826580C0")]
		public void Clear<T>(T NMGALPBKFJN) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x602F630", Offset = "0x602E230", VA = "0x18602F630")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2657F80", Offset = "0x2656B80", VA = "0x182657F80")]
		private AJJDCOMNPCE BBDAPCDGAHL<T>(T NMGALPBKFJN) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public void TrackInstantiation(string AABAIEONOCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public void EnableStats(bool IGLDAKLLNLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x602F7A0", Offset = "0x602E3A0", VA = "0x18602F7A0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class AJJDCOMNPCE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface GLAIOONBEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IBKIJMGNJEK(bool BNMAAIDFKDO);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string ODBDFCEODFK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int KLINPKHIGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void BIPOFLGKHMN(int EMHEDPDPEMP, Action<Component> IGPPEIBJIDI);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component EPNOJHHKCNC(Action<Component> CPDMHIECMAE);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool IJNJJGHDBFD(Component GOOEIIAOGIE);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void GMINFKPEKLF();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x602DCA0", Offset = "0x602C8A0", VA = "0x18602DCA0")]
	protected void NKFALFLLOBC(Component IIFJCGIHMIN, bool BNMAAIDFKDO, bool MMLFGHJMFFN, bool MENJKBMNLKC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x602DA20", Offset = "0x602C620", VA = "0x18602DA20")]
	protected void IBDAABFOMJP(Transform NALJAKKIMAH, bool BNMAAIDFKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	protected AJJDCOMNPCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MJGNNMKALAM<T> : AJJDCOMNPCE where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T NMGALPBKFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool BAOJAFLGEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool MMLFGHJMFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> NFODNIBAFEN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string ODBDFCEODFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3A20", Offset = "0x3CB2620", VA = "0x183CB3A20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int KLINPKHIGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3C20", Offset = "0x3CB2820", VA = "0x183CB3C20", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3CB3F70", Offset = "0x3CB2B70", VA = "0x183CB3F70")]
	public MJGNNMKALAM(T NMGALPBKFJN, ObjectPool BAOJAFLGEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3CB36A0", Offset = "0x3CB22A0", VA = "0x183CB36A0", Slot = "6")]
	public override void BIPOFLGKHMN(int EMHEDPDPEMP, Action<Component> CPDMHIECMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3CB37B0", Offset = "0x3CB23B0", VA = "0x183CB37B0", Slot = "7")]
	public override Component EPNOJHHKCNC(Action<Component> CPDMHIECMAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3CB3C60", Offset = "0x3CB2860", VA = "0x183CB3C60", Slot = "8")]
	public override bool IJNJJGHDBFD(Component GOOEIIAOGIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3CB3A40", Offset = "0x3CB2640", VA = "0x183CB3A40", Slot = "9")]
	public override void GMINFKPEKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3CB3E00", Offset = "0x3CB2A00", VA = "0x183CB3E00")]
	private T LFIAFACHLBE()
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
		public interface HGGBOKAKHKA
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject GJBBEEALGNC
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
		[Cpp2IlInjected.Address(RVA = "0x602F2B0", Offset = "0x602DEB0", VA = "0x18602F2B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x602F5A0", Offset = "0x602E1A0", VA = "0x18602F5A0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool GGGHPJBNGCE;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject MBJHKHOBEJO;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool IDAIJJLMAFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x602F8F0", Offset = "0x602E4F0", VA = "0x18602F8F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x602F830", Offset = "0x602E430", VA = "0x18602F830")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x602F100", Offset = "0x602DD00", VA = "0x18602F100")]
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
		public AJJDCOMNPCE PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x771300", Offset = "0x76FF00", VA = "0x180771300")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IJKNKCBCNHH
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int OLDKAHFIFNE(PooledParticle.MLHFMINPAEC JMOMMEIMHKF);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum JLHMBPLKLAO
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
		public enum MLHFMINPAEC
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
		public interface PMGNNPGFBKI
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool PBMFDNCAIDI
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 LILHAPAPGHC
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera CBGPHMJAJFD
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
			[Cpp2IlInjected.Address(RVA = "0x50FBAA0", Offset = "0x50FA6A0", VA = "0x1850FBAA0")]
			public ColorConfiguration(ParticleSystem DCOCNJPFAGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x602DEE0", Offset = "0x602CAE0", VA = "0x18602DEE0")]
			public void KFHAPLPLOBJ(Color EFLLOODPMDH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class OGBEGLOBPKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public OGBEGLOBPKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x602F280", Offset = "0x602DE80", VA = "0x18602F280")]
			internal void OFMPHIHDPIF(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class DLMLLJFEAHL : IEnumerator<MJMKCFLBGFK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private MJMKCFLBGFK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private PMGNNPGFBKI <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private MJMKCFLBGFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
			[DebuggerHidden]
			public DLMLLJFEAHL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x602E0D0", Offset = "0x602CCD0", VA = "0x18602E0D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x602E6E0", Offset = "0x602D2E0", VA = "0x18602E6E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class BANKLEIHMIA : IEnumerator<MJMKCFLBGFK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private MJMKCFLBGFK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private MJMKCFLBGFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
			[DebuggerHidden]
			public BANKLEIHMIA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x602DE20", Offset = "0x602CA20", VA = "0x18602DE20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x602DE90", Offset = "0x602CA90", VA = "0x18602DE90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> OPIIMDOPHMM;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<IJKNKCBCNHH> AKIALKOHADL;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> IEAAGFOFOHD;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static IHPHLOENKON BMNGGNHKJLK;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float KGCLDBPDKJC = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool KKFKGMJEEGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int LMFEMFHLNHJ;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private MLHFMINPAEC category;

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
		private ParticleSystem.MinMaxGradient[] ABGCFGLCHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool PBOEKOIHDHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float FLIFGNFFBEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float DIBEGEJLDPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform LNECAPBDEHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 KHJFCAPEEAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 GMKMAFGLPIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private JLHMBPLKLAO INDLBJCBJFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private IHPHLOENKON HCBGAKPDGFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool AFDEACKAHJG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> CFOBFHABLGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x60337C0", Offset = "0x60323C0", VA = "0x1860337C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MLHFMINPAEC HEPNPIBDPIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x799820", Offset = "0x798420", VA = "0x180799820")]
			get
			{
				return default(MLHFMINPAEC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int CCKODMDMPOH
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7786A0", Offset = "0x7772A0", VA = "0x1807786A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool CGCCNAIGNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x60334F0", Offset = "0x60320F0", VA = "0x1860334F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int PIDPNBDPPND
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6033670", Offset = "0x6032270", VA = "0x186033670")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool GHNBIKIIDLK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6030280", Offset = "0x602EE80", VA = "0x186030280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem KCLFCJEGHOF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x773600", Offset = "0x772200", VA = "0x180773600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x773820", Offset = "0x772420", VA = "0x180773820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] PNPGAFAOIOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7766D0", Offset = "0x7752D0", VA = "0x1807766D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x77D0D0", Offset = "0x77BCD0", VA = "0x18077D0D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] PKNFLMNBPDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x773610", Offset = "0x772210", VA = "0x180773610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x776700", Offset = "0x775300", VA = "0x180776700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private JLHMBPLKLAO NMALNHJKJDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xDA0A40", Offset = "0xD9F640", VA = "0x180DA0A40")]
			get
			{
				return default(JLHMBPLKLAO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6030A80", Offset = "0x602F680", VA = "0x186030A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action CGLLAEFIMOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6033450", Offset = "0x6032050", VA = "0x186033450")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6033810", Offset = "0x6032410", VA = "0x186033810")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6032DE0", Offset = "0x60319E0", VA = "0x186032DE0")]
		public static PooledParticle TryPlayPrefab(PooledParticle NMGALPBKFJN, Vector3 CFCLFCDKKPD, Quaternion HFKFMHAMLPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6032F50", Offset = "0x6031B50", VA = "0x186032F50")]
		public static PooledParticle TryPlayPrefab(PooledParticle NMGALPBKFJN, Vector3 CFCLFCDKKPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6032490", Offset = "0x6031090", VA = "0x186032490")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6030650", Offset = "0x602F250", VA = "0x186030650")]
		private void EAOGJJLHHMM(bool LPOCOBOKBAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6031730", Offset = "0x6030330", VA = "0x186031730")]
		[IteratorStateMachine(typeof(DLMLLJFEAHL))]
		private static IEnumerator<MJMKCFLBGFK> NEOPFKKBPPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6030300", Offset = "0x602EF00", VA = "0x186030300")]
		private static void CKPHLBKCOMI(Stopwatch AEIJEHEMJFD, Vector3 AJNNFJKNOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6030E00", Offset = "0x602FA00", VA = "0x186030E00")]
		private static int LMOGGOOAAHC(PooledParticle AGIBINPMDEG, PooledParticle BBPKFALMKGI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6031790", Offset = "0x6030390", VA = "0x186031790")]
		private static int OLDKAHFIFNE(MLHFMINPAEC JMOMMEIMHKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6030C00", Offset = "0x602F800", VA = "0x186030C00")]
		protected void JMJLFMENPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6031120", Offset = "0x602FD20", VA = "0x186031120")]
		protected void MPIHNMBJMEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6030050", Offset = "0x602EC50", VA = "0x186030050", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6030EB0", Offset = "0x602FAB0", VA = "0x186030EB0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x60318A0", Offset = "0x60304A0", VA = "0x1860318A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x60309F0", Offset = "0x602F5F0", VA = "0x1860309F0")]
		[IteratorStateMachine(typeof(BANKLEIHMIA))]
		private IEnumerator<MJMKCFLBGFK> FGABHIHPCHK(float EJGELOGDBKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6030AA0", Offset = "0x602F6A0", VA = "0x186030AA0")]
		private void IJNJJGHDBFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6032BF0", Offset = "0x60317F0", VA = "0x186032BF0")]
		public void SetDuration(float EJGELOGDBKE, bool FCHBAGMLKFC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6031A50", Offset = "0x6030650", VA = "0x186031A50")]
		public void Play(Transform IFEDDGGGGHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6032100", Offset = "0x6030D00", VA = "0x186032100")]
		public void Play(Transform IFEDDGGGGHI, bool IBCMAFIMPIE, float DOFDDILIIBD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6031BB0", Offset = "0x60307B0", VA = "0x186031BB0")]
		public void Play(Transform IFEDDGGGGHI, Vector3 GMKMAFGLPIN, bool IBCMAFIMPIE, float DOFDDILIIBD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6031D00", Offset = "0x6030900", VA = "0x186031D00")]
		public void Play(Transform KCKEOKFADAG, Quaternion HFKFMHAMLPE, bool IBCMAFIMPIE = false, float DOFDDILIIBD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6032270", Offset = "0x6030E70", VA = "0x186032270")]
		public void Play(Transform KCKEOKFADAG, Vector3 GMKMAFGLPIN, Quaternion HFKFMHAMLPE, bool IBCMAFIMPIE = false, float DOFDDILIIBD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6031F20", Offset = "0x6030B20", VA = "0x186031F20")]
		public void Play(Vector3 CFCLFCDKKPD, Quaternion HFKFMHAMLPE, Vector3 OAAOAKNCDMA, bool IBCMAFIMPIE = false, float DOFDDILIIBD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6031E60", Offset = "0x6030A60", VA = "0x186031E60")]
		public void Play(Vector3 CFCLFCDKKPD, Quaternion HFKFMHAMLPE, bool IBCMAFIMPIE = false, float DOFDDILIIBD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6031FF0", Offset = "0x6030BF0", VA = "0x186031FF0")]
		public void Play(bool IBCMAFIMPIE = false, float DOFDDILIIBD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6032D50", Offset = "0x6031950", VA = "0x186032D50")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6032CC0", Offset = "0x60318C0", VA = "0x186032CC0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6030720", Offset = "0x602F320", VA = "0x186030720")]
		private void EJBPFLJBJDO(float EJGELOGDBKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x60308B0", Offset = "0x602F4B0", VA = "0x1860308B0")]
		private void EJKNNMBAFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x60323A0", Offset = "0x6030FA0", VA = "0x1860323A0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6032610", Offset = "0x6031210", VA = "0x186032610")]
		public void SetColor(Color EFLLOODPMDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6031920", Offset = "0x6030520", VA = "0x186031920")]
		private void PLOHJFPOCEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x60333C0", Offset = "0x6031FC0", VA = "0x1860333C0")]
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
