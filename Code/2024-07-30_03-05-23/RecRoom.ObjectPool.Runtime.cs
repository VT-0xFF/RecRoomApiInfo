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
		[Cpp2IlInjected.Address(RVA = "0x6C81310", Offset = "0x6C7F910", VA = "0x186C81310")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles KBOBDAFPJFJ, float LOJACDPJLNH, Vector3 MCPNOOFMAHG, Quaternion GLKHDAMNPBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6C80FB0", Offset = "0x6C7F5B0", VA = "0x186C80FB0")]
		public void SetDamageValue(float LOJACDPJLNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6C81490", Offset = "0x6C7FA90", VA = "0x186C81490")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CFEIECCHJEJ<T> : FGBFKCLKPNC<T>, GJFFIMHAENI, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DHBEJNNOMBE<T> : GJFFIMHAENI, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MDLHPCADGGM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NIEMEJPNHGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class GENPLMNHEON<T> : BHNOEEFMNHG<T>, CFEIECCHJEJ<T>, FGBFKCLKPNC<T>, GJFFIMHAENI, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GJAFDMAFGBO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public GENPLMNHEON<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public GJAFDMAFGBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3D0E760", Offset = "0x3D0CD60", VA = "0x183D0E760")]
			internal void HJPMHDMMJFA(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2A0FF30", Offset = "0x2A0E530", VA = "0x182A0FF30")]
			internal void DHFPJFNBGCL(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private FNMJFLPICID<T> MAMDHIHEEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool AJNEMINIDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T ADJKKNJDKEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool DALIKEFGADH;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3D0A410", Offset = "0x3D08A10", VA = "0x183D0A410")]
		public GENPLMNHEON(FNMJFLPICID<T> MAMDHIHEEBN, ObjectPool AJNEMINIDIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3D0A2A0", Offset = "0x3D088A0", VA = "0x183D0A2A0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class IFHOKOLOHAL<T> : OGONOIIKGAI, DHBEJNNOMBE<T>, GJFFIMHAENI, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class ENFBGGNCMCK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public IFHOKOLOHAL<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public ENFBGGNCMCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x388B7E0", Offset = "0x3889DE0", VA = "0x18388B7E0")]
			internal void HJPMHDMMJFA(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xBD8370", Offset = "0xBD6970", VA = "0x180BD8370")]
			internal void DHFPJFNBGCL(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private FNMJFLPICID<T> MAMDHIHEEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool DALIKEFGADH;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3E68790", Offset = "0x3E66D90", VA = "0x183E68790")]
		public IFHOKOLOHAL(FNMJFLPICID<T> MAMDHIHEEBN, ObjectPool AJNEMINIDIB, int CDEIHNOPAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3E68730", Offset = "0x3E66D30", VA = "0x183E68730", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BCFKMPOHMOG<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NIEMEJPNHGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public BHNOEEFMNHG<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public FNMJFLPICID<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public BCFKMPOHMOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4EC0490", Offset = "0x4EBEA90", VA = "0x184EC0490")]
		internal void FGLFBJGHBCF(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4EC0590", Offset = "0x4EBEB90", VA = "0x184EC0590")]
		internal void OANANNCAIFE(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4EC0540", Offset = "0x4EBEB40", VA = "0x184EC0540")]
		internal void MKBIDLJIFMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<MDLHPCADGGM> JCBAJHCIJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private NJAKFEMJIMN GABCEENBNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool AJNEMINIDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool DALIKEFGADH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C7FFB0", Offset = "0x6C7E5B0", VA = "0x186C7FFB0")]
	private static void ELNOBGMPJEJ(Component JLFHFDLINDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C80540", Offset = "0x6C7EB40", VA = "0x186C80540")]
	public NIEMEJPNHGO(string NJOOCAPBHFJ, int GMBCLNJENEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2CD84B0", Offset = "0x2CD6AB0", VA = "0x182CD84B0")]
	public CFEIECCHJEJ<T> MFHJCEBKALF<T>(AssetReference DNJEBHBJAJA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2CD83D0", Offset = "0x2CD69D0", VA = "0x182CD83D0")]
	public DHBEJNNOMBE<T> IBHHGIJGIBC<T>(AssetReference DNJEBHBJAJA, int BMKFLHFENBJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7FA0", Offset = "0x2CD65A0", VA = "0x182CD7FA0")]
	public FGBFKCLKPNC<bool> ELDMDCADOCM<T>(AssetReference DNJEBHBJAJA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C7FEC0", Offset = "0x6C7E4C0", VA = "0x186C7FEC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C80380", Offset = "0x6C7E980", VA = "0x186C80380")]
	private void KMMALBNPALN(UnityEngine.Object JDBONCLCCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6C801F0", Offset = "0x6C7E7F0", VA = "0x186C801F0")]
	private ObjectPool IGDDDDNBODD(string NJOOCAPBHFJ)
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
		private static GlobalPool CKEENOLPHIJ;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject EKALIEHHELE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool CFNNMJAMDBB
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6C7F2C0", Offset = "0x6C7D8C0", VA = "0x186C7F2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0A40", Offset = "0x2B9F040", VA = "0x182BA0A40")]
		public static void SafeRelease<T>(T NJKKPOFFNNJ) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6C7F1F0", Offset = "0x6C7D7F0", VA = "0x186C7F1F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C7F2B0", Offset = "0x6C7D8B0", VA = "0x186C7F2B0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, JHDKMKCNIFI> LFHOIGEJIOP;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2D19A00", Offset = "0x2D18000", VA = "0x182D19A00")]
		public T Acquire<T>(T KBOBDAFPJFJ, [Optional] Action<Component> MOFKECPFBIK) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2D19DC0", Offset = "0x2D183C0", VA = "0x182D19DC0")]
		public bool Release<T>(T NJKKPOFFNNJ) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2D19D50", Offset = "0x2D18350", VA = "0x182D19D50")]
		public void Prefill<T>(T KBOBDAFPJFJ, int NBMPJNKAJIP, [Optional] Action<Component> MCCILIHIDEI) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2D19B70", Offset = "0x2D18170", VA = "0x182D19B70")]
		public bool Exists<T>(T KBOBDAFPJFJ) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2D19AC0", Offset = "0x2D180C0", VA = "0x182D19AC0")]
		public void Clear<T>(T KBOBDAFPJFJ) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6C80B50", Offset = "0x6C7F150", VA = "0x186C80B50")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2D19C10", Offset = "0x2D18210", VA = "0x182D19C10")]
		private JHDKMKCNIFI MAFLPHFMAPC<T>(T KBOBDAFPJFJ) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public void TrackInstantiation(string PKLIGHMDAHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public void EnableStats(bool ANMLFDIOKPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6C80CC0", Offset = "0x6C7F2C0", VA = "0x186C80CC0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class JHDKMKCNIFI
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface EKMAMOLAJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DOIMFIOCNOB(bool HBGFFBOKCIG);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string OABCLOFHIGC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int APJFJGJGCGB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void IBHHGIJGIBC(int BMKFLHFENBJ, Action<Component> MCCILIHIDEI);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component MFHJCEBKALF(Action<Component> MOFKECPFBIK);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool EKHKOALGJHM(Component IFGDBEFLMIB);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void DMCFOMNOLLC();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C7FD10", Offset = "0x6C7E310", VA = "0x186C7FD10")]
	protected void PMEFPDOOJGA(Component NJKKPOFFNNJ, bool HBGFFBOKCIG, bool CEBLGFPPGJP, bool NMNAFDFFPCL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C7FA90", Offset = "0x6C7E090", VA = "0x186C7FA90")]
	protected void KGDHKDILACN(Transform AABJAMBHCDC, bool HBGFFBOKCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	protected JHDKMKCNIFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IJCNKNMKIAC<T> : JHDKMKCNIFI where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T KBOBDAFPJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool CAOOFJJNBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool CEBLGFPPGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> ENIDDBCGNEF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string OABCLOFHIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3E7AC70", Offset = "0x3E79270", VA = "0x183E7AC70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int APJFJGJGCGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A960", Offset = "0x3E78F60", VA = "0x183E7A960", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3E7AF20", Offset = "0x3E79520", VA = "0x183E7AF20")]
	public IJCNKNMKIAC(T KBOBDAFPJFJ, ObjectPool CAOOFJJNBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3E7AB40", Offset = "0x3E79140", VA = "0x183E7AB40", Slot = "6")]
	public override void IBHHGIJGIBC(int BMKFLHFENBJ, Action<Component> MOFKECPFBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3E7AC90", Offset = "0x3E79290", VA = "0x183E7AC90", Slot = "7")]
	public override Component MFHJCEBKALF(Action<Component> MOFKECPFBIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3E7A7A0", Offset = "0x3E78DA0", VA = "0x183E7A7A0", Slot = "8")]
	public override bool EKHKOALGJHM(Component IFGDBEFLMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3E7A590", Offset = "0x3E78B90", VA = "0x183E7A590", Slot = "9")]
	public override void DMCFOMNOLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3E7A9C0", Offset = "0x3E78FC0", VA = "0x183E7A9C0")]
	private T GHEDMCCFCEB()
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
		public interface LCFICMLAENL
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject IHGAMKIMGHF
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
		[Cpp2IlInjected.Address(RVA = "0x6C807D0", Offset = "0x6C7EDD0", VA = "0x186C807D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6C80AC0", Offset = "0x6C7F0C0", VA = "0x186C80AC0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool CKEENOLPHIJ;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject EKALIEHHELE;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool CFNNMJAMDBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6C80E10", Offset = "0x6C7F410", VA = "0x186C80E10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6C80D50", Offset = "0x6C7F350", VA = "0x186C80D50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6C7F2B0", Offset = "0x6C7D8B0", VA = "0x186C7F2B0")]
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
		public JHDKMKCNIFI PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x867780", Offset = "0x865D80", VA = "0x180867780")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OEHAAGJHEME
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int OFGJGIOBBEH(PooledParticle.LGJJHBJAGNA KJMDOBJEJGB);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum HFIABKEGEAE
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
		public enum LGJJHBJAGNA
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
		public interface BIHKNHMMBHD
		{
			[Cpp2IlInjected.Token(Token = "0x17000012")]
			bool BNCGLDFAAPM
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			Vector3 EPKFIDGMFGB
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Camera PABLCPJIDBJ
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
			[Cpp2IlInjected.Address(RVA = "0x5BB4560", Offset = "0x5BB2B60", VA = "0x185BB4560")]
			public ColorConfiguration(ParticleSystem MHFMJNJOLBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6C7EF40", Offset = "0x6C7D540", VA = "0x186C7EF40")]
			public void EDEPFMCBKDH(Color PHHAMGLLFIF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class LEAEFEBPJNB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public LEAEFEBPJNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6C7FE90", Offset = "0x6C7E490", VA = "0x186C7FE90")]
			internal void DFEACBJICJG(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class HGIFOBIFOBG : IEnumerator<FEEHCBLGINO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private FEEHCBLGINO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private BIHKNHMMBHD <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private FEEHCBLGINO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
			[DebuggerHidden]
			public HGIFOBIFOBG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6C7F430", Offset = "0x6C7DA30", VA = "0x186C7F430", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6C7FA40", Offset = "0x6C7E040", VA = "0x186C7FA40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class FBGMMPAHMND : IEnumerator<FEEHCBLGINO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private FEEHCBLGINO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private FEEHCBLGINO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
			[DebuggerHidden]
			public FBGMMPAHMND(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6C7F130", Offset = "0x6C7D730", VA = "0x186C7F130", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6C7F1A0", Offset = "0x6C7D7A0", VA = "0x186C7F1A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> CFLIDLENDKA;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<OEHAAGJHEME> HIMLLEKIKHM;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> LBNCMIJACML;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static EKNCDBKDOPI CGFHBLCLODM;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float OAGHDPLNKFE = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool JGKNIJOJCIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int MEFDOJGDKMF;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private LGJJHBJAGNA category;

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
		private ParticleSystem.MinMaxGradient[] BFOABGMJMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool LDCBCHACMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float OHFGPCLDFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float JPJNPFKLBDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform CDHCEOFIDNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 JNKJHKEPJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 MDENLGHEBHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private HFIABKEGEAE LPKHOCEBIEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private EKNCDBKDOPI NFCGEABAFPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool PGLDILKGHNA;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> BPAAFDAIIOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6C84D00", Offset = "0x6C83300", VA = "0x186C84D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public LGJJHBJAGNA NGFHOHDHIOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x88ECA0", Offset = "0x88D2A0", VA = "0x18088ECA0")]
			get
			{
				return default(LGJJHBJAGNA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int NCGLOJAEKKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x86C7E0", Offset = "0x86ADE0", VA = "0x18086C7E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FKKNICKBACF
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6C84A30", Offset = "0x6C83030", VA = "0x186C84A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int NIOLOBAGOLK
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6C84BB0", Offset = "0x6C831B0", VA = "0x186C84BB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool HJLJHHALIMI
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6C81A00", Offset = "0x6C80000", VA = "0x186C81A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem HOPKPDHPHJN
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x868210", Offset = "0x866810", VA = "0x180868210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x868280", Offset = "0x866880", VA = "0x180868280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] HGJADNAKAFI
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x868240", Offset = "0x866840", VA = "0x180868240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] HPDAILDBDKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x868EE0", Offset = "0x8674E0", VA = "0x180868EE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x868CD0", Offset = "0x8672D0", VA = "0x180868CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private HFIABKEGEAE IJECCFDFEED
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x104D2B0", Offset = "0x104B8B0", VA = "0x18104D2B0")]
			get
			{
				return default(HFIABKEGEAE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6C822D0", Offset = "0x6C808D0", VA = "0x186C822D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action BGNAMAPKPAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6C84990", Offset = "0x6C82F90", VA = "0x186C84990")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6C84D50", Offset = "0x6C83350", VA = "0x186C84D50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6C84320", Offset = "0x6C82920", VA = "0x186C84320")]
		public static PooledParticle TryPlayPrefab(PooledParticle KBOBDAFPJFJ, Vector3 MCPNOOFMAHG, Quaternion GLKHDAMNPBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6C84490", Offset = "0x6C82A90", VA = "0x186C84490")]
		public static PooledParticle TryPlayPrefab(PooledParticle KBOBDAFPJFJ, Vector3 MCPNOOFMAHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6C839D0", Offset = "0x6C81FD0", VA = "0x186C839D0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6C81930", Offset = "0x6C7FF30", VA = "0x186C81930")]
		private void BPOJLDLOFLL(bool AKKNAKBNOJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6C82750", Offset = "0x6C80D50", VA = "0x186C82750")]
		[IteratorStateMachine(typeof(HGIFOBIFOBG))]
		private static IEnumerator<FEEHCBLGINO> OFJJDDJPMBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6C822F0", Offset = "0x6C808F0", VA = "0x186C822F0")]
		private static void OAACIIGJOFK(Stopwatch LAEFIIJCIDG, Vector3 AGCKLKJOKKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6C81DB0", Offset = "0x6C803B0", VA = "0x186C81DB0")]
		private static int KBBJFBMGHFB(PooledParticle OIMGCNDKIAD, PooledParticle LMBIFCGLAFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6C82640", Offset = "0x6C80C40", VA = "0x186C82640")]
		private static int OFGJGIOBBEH(LGJJHBJAGNA KJMDOBJEJGB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6C81E60", Offset = "0x6C80460", VA = "0x186C81E60")]
		protected void LKLCIFGECMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6C827B0", Offset = "0x6C80DB0", VA = "0x186C827B0")]
		protected void ONNKADKOOCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6C81570", Offset = "0x6C7FB70", VA = "0x186C81570", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6C82060", Offset = "0x6C80660", VA = "0x186C82060")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6C82DE0", Offset = "0x6C813E0", VA = "0x186C82DE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6C81D20", Offset = "0x6C80320", VA = "0x186C81D20")]
		[IteratorStateMachine(typeof(FBGMMPAHMND))]
		private IEnumerator<FEEHCBLGINO> GNAMOCODHBP(float JCFJIBJJHJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6C81BC0", Offset = "0x6C801C0", VA = "0x186C81BC0")]
		private void EKHKOALGJHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6C84130", Offset = "0x6C82730", VA = "0x186C84130")]
		public void SetDuration(float JCFJIBJJHJJ, bool EOGMJLMBNJH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6C82F90", Offset = "0x6C81590", VA = "0x186C82F90")]
		public void Play(Transform MHLAENHIPMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6C83640", Offset = "0x6C81C40", VA = "0x186C83640")]
		public void Play(Transform MHLAENHIPMG, bool NDPCIOGIBDO, float EGDGCJBMFOL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C830F0", Offset = "0x6C816F0", VA = "0x186C830F0")]
		public void Play(Transform MHLAENHIPMG, Vector3 MDENLGHEBHL, bool NDPCIOGIBDO, float EGDGCJBMFOL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C83240", Offset = "0x6C81840", VA = "0x186C83240")]
		public void Play(Transform FKMJLJGLOGH, Quaternion GLKHDAMNPBA, bool NDPCIOGIBDO = false, float EGDGCJBMFOL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C837B0", Offset = "0x6C81DB0", VA = "0x186C837B0")]
		public void Play(Transform FKMJLJGLOGH, Vector3 MDENLGHEBHL, Quaternion GLKHDAMNPBA, bool NDPCIOGIBDO = false, float EGDGCJBMFOL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6C83460", Offset = "0x6C81A60", VA = "0x186C83460")]
		public void Play(Vector3 MCPNOOFMAHG, Quaternion GLKHDAMNPBA, Vector3 NPPDGHLPBPO, bool NDPCIOGIBDO = false, float EGDGCJBMFOL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6C833A0", Offset = "0x6C819A0", VA = "0x186C833A0")]
		public void Play(Vector3 MCPNOOFMAHG, Quaternion GLKHDAMNPBA, bool NDPCIOGIBDO = false, float EGDGCJBMFOL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6C83530", Offset = "0x6C81B30", VA = "0x186C83530")]
		public void Play(bool NDPCIOGIBDO = false, float EGDGCJBMFOL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6C84290", Offset = "0x6C82890", VA = "0x186C84290")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6C84200", Offset = "0x6C82800", VA = "0x186C84200")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6C817A0", Offset = "0x6C7FDA0", VA = "0x186C817A0")]
		private void BIJJHAHFHPI(float JCFJIBJJHJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6C81A80", Offset = "0x6C80080", VA = "0x186C81A80")]
		private void DLHFOINHMLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6C838E0", Offset = "0x6C81EE0", VA = "0x186C838E0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6C83B50", Offset = "0x6C82150", VA = "0x186C83B50")]
		public void SetColor(Color PHHAMGLLFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6C82E60", Offset = "0x6C81460", VA = "0x186C82E60")]
		private void PEDKMFGLGFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6C84900", Offset = "0x6C82F00", VA = "0x186C84900")]
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
