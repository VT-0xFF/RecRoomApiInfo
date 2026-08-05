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
		[Cpp2IlInjected.Address(RVA = "0x672EBB0", Offset = "0x672DDB0", VA = "0x18672EBB0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles GDEKLMNKJBC, float FDDPFMJOHLO, Vector3 INLGLHIPOMC, Quaternion HEGBBJCMANH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x672E9B0", Offset = "0x672DBB0", VA = "0x18672E9B0")]
		public void SetDamageValue(float FDDPFMJOHLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x672ED70", Offset = "0x672DF70", VA = "0x18672ED70")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EKIMJIKFFIB<T> : global::NCOKFFGPIJM<T>, LAHBDKNMNHN, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FOPKGELNMBL<T> : LAHBDKNMNHN, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LOBCAJAIIJD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FHHJCBBDDJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MNHICMNENKP<T> : global::PHLHFLLLDLK<T>, global::EKIMJIKFFIB<T>, global::NCOKFFGPIJM<T>, LAHBDKNMNHN, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class DDAGFPHPDHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public MNHICMNENKP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
			public DDAGFPHPDHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x20BC5B0", Offset = "0x20BB7B0", VA = "0x1820BC5B0")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x20BC6B0", Offset = "0x20BB8B0", VA = "0x1820BC6B0")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::EHOCIICLNGN<T> FFLHBOPABGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool JPOALJOJAOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T CMDPMJBEBAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool KBDIBPJIHNN;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2411C00", Offset = "0x2410E00", VA = "0x182411C00")]
		public MNHICMNENKP(global::EHOCIICLNGN<T> FFLHBOPABGK, ObjectPool JPOALJOJAOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2411AC0", Offset = "0x2410CC0", VA = "0x182411AC0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class PEBENCJCBHG<T> : DBIPHDIEBCM, global::FOPKGELNMBL<T>, LAHBDKNMNHN, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class CFFKHDBPBCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public PEBENCJCBHG<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
			public CFFKHDBPBCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x26F0910", Offset = "0x26EFB10", VA = "0x1826F0910")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x26F09F0", Offset = "0x26EFBF0", VA = "0x1826F09F0")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private global::EHOCIICLNGN<T> FFLHBOPABGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool KBDIBPJIHNN;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x30C2D80", Offset = "0x30C1F80", VA = "0x1830C2D80")]
		public PEBENCJCBHG(global::EHOCIICLNGN<T> FFLHBOPABGK, ObjectPool JPOALJOJAOF, int MIDOENLEBOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x30C2D30", Offset = "0x30C1F30", VA = "0x1830C2D30", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GKIFKPMMKLH<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public FHHJCBBDDJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::PHLHFLLLDLK<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::EHOCIICLNGN<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public GKIFKPMMKLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x23B4320", Offset = "0x23B3520", VA = "0x1823B4320")]
		internal void <Exists>b__0(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x23B43C0", Offset = "0x23B35C0", VA = "0x1823B43C0")]
		internal void <Exists>b__1(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x23B4420", Offset = "0x23B3620", VA = "0x1823B4420")]
		internal void <Exists>b__2()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<LOBCAJAIIJD> AGBAHMFOELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private ELMEOFGIDDH JAJPEDKEIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool JPOALJOJAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool KBDIBPJIHNN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool JBAABFJBIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x672C390", Offset = "0x672B590", VA = "0x18672C390")]
	private static void AJDMLKILHMH(Component KLEOIMLJIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x672CA40", Offset = "0x672BC40", VA = "0x18672CA40")]
	public FHHJCBBDDJD(string IEACNHGAIIE, int PBCLAFKCBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1494480", Offset = "0x1493680", VA = "0x181494480")]
	public global::EKIMJIKFFIB<T> CKPFPCMEEHI<T>(AssetReference GLKIENFPCBN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1494510", Offset = "0x1493710", VA = "0x181494510")]
	public global::FOPKGELNMBL<T> HNEFMHENPMI<T>(AssetReference GLKIENFPCBN, int BFFJHKFEFPP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x14945C0", Offset = "0x14937C0", VA = "0x1814945C0")]
	public global::NCOKFFGPIJM<bool> NHKKABBPFMM<T>(AssetReference GLKIENFPCBN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x672C720", Offset = "0x672B920", VA = "0x18672C720", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x672C5E0", Offset = "0x672B7E0", VA = "0x18672C5E0")]
	private void DMLBLOJJEPC(UnityEngine.Object NAHLNNEGIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x672C830", Offset = "0x672BA30", VA = "0x18672C830")]
	private ObjectPool LMPMLJMBACK(string IEACNHGAIIE)
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
		private static GlobalPool EJDHGIDGKIB;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject MOCHAIGJNIA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool OFDKPDDLIJC
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x672CDE0", Offset = "0x672BFE0", VA = "0x18672CDE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x22698E0", Offset = "0x2268AE0", VA = "0x1822698E0")]
		public static void SafeRelease<T>(T ICHBECDKHOJ) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x672CCE0", Offset = "0x672BEE0", VA = "0x18672CCE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x672CDD0", Offset = "0x672BFD0", VA = "0x18672CDD0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, NIIKGHOMJLA> HCDOKNMFCBA;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x205D150", Offset = "0x205C350", VA = "0x18205D150")]
		public T Acquire<T>(T GDEKLMNKJBC, [Optional] Action<Component> PJHKMHAHODJ) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x205D4E0", Offset = "0x205C6E0", VA = "0x18205D4E0")]
		public bool Release<T>(T ICHBECDKHOJ) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x205D480", Offset = "0x205C680", VA = "0x18205D480")]
		public void Prefill<T>(T GDEKLMNKJBC, int ANBIMKAPPGP, [Optional] Action<Component> EPFDJKEEJKO) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x205D3D0", Offset = "0x205C5D0", VA = "0x18205D3D0")]
		public bool Exists<T>(T GDEKLMNKJBC) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x205D1E0", Offset = "0x205C3E0", VA = "0x18205D1E0")]
		public void Clear<T>(T GDEKLMNKJBC) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x672E500", Offset = "0x672D700", VA = "0x18672E500")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x205D290", Offset = "0x205C490", VA = "0x18205D290")]
		private NIIKGHOMJLA DNJOAFKJGJP<T>(T GDEKLMNKJBC) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		public void TrackInstantiation(string CHEIDKCNKED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		public void EnableStats(bool DACDLCDMGNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x672E650", Offset = "0x672D850", VA = "0x18672E650")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class NIIKGHOMJLA
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface DLAAAIOLKJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CEPKDMGEBIH(bool FBHDABEFLKL);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract Component MMCPIFLFKCA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract string PALADLMJNAK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int BGJHLJKKNGE
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void HNEFMHENPMI(int BFFJHKFEFPP, Action<Component> EPFDJKEEJKO);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Component CKPFPCMEEHI(Action<Component> PJHKMHAHODJ);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool MBLNKLCECMD(Component NPODHMILIGI);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void GLBPPAIACJF();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x672DFB0", Offset = "0x672D1B0", VA = "0x18672DFB0")]
	protected void GOLFONJFOEK(Component ICHBECDKHOJ, bool FBHDABEFLKL, bool NNHENOHHFGF, bool DDJFHDPALFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x672DDB0", Offset = "0x672CFB0", VA = "0x18672DDB0")]
	protected void GLDIDCOKDLK(Transform POFHBCJOFNB, bool FBHDABEFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	protected NIIKGHOMJLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JOOGCNHGOHO<T> : NIIKGHOMJLA where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T GDEKLMNKJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool OGNPBCGMDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool NNHENOHHFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> IBIMMLHPGJI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Component MMCPIFLFKCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override string PALADLMJNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2141680", Offset = "0x2140880", VA = "0x182141680", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override int BGJHLJKKNGE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2141D70", Offset = "0x2140F70", VA = "0x182141D70", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2141F30", Offset = "0x2141130", VA = "0x182141F30")]
	public JOOGCNHGOHO(T GDEKLMNKJBC, ObjectPool OGNPBCGMDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2141C60", Offset = "0x2140E60", VA = "0x182141C60", Slot = "7")]
	public override void HNEFMHENPMI(int BFFJHKFEFPP, Action<Component> PJHKMHAHODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2141800", Offset = "0x2140A00", VA = "0x182141800", Slot = "8")]
	public override Component CKPFPCMEEHI(Action<Component> PJHKMHAHODJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2141DA0", Offset = "0x2140FA0", VA = "0x182141DA0", Slot = "9")]
	public override bool MBLNKLCECMD(Component NPODHMILIGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2141A70", Offset = "0x2140C70", VA = "0x182141A70", Slot = "10")]
	public override void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x21416A0", Offset = "0x21408A0", VA = "0x1821416A0")]
	private T CCDDALBFLHF()
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
		public interface CJKCIFNBNDH
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			GameObject OHIEJHNCFBD
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x672E130", Offset = "0x672D330", VA = "0x18672E130")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x672E480", Offset = "0x672D680", VA = "0x18672E480")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool EJDHGIDGKIB;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject MOCHAIGJNIA;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static PersistentGlobalPool OFDKPDDLIJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x672E7C0", Offset = "0x672D9C0", VA = "0x18672E7C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x672E6D0", Offset = "0x672D8D0", VA = "0x18672E6D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x672CDD0", Offset = "0x672BFD0", VA = "0x18672CDD0")]
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
		public NIIKGHOMJLA PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6FB670", Offset = "0x6FA870", VA = "0x1806FB670")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NDKBIHNDDMO
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CICBKJOCDLD(PooledParticle.MIBOCAFKAHH JNKJFJLJKNJ);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum IJCBDINCGPO
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
		public enum MIBOCAFKAHH
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
		public interface FDDHOMABJHP
		{
			[Cpp2IlInjected.Token(Token = "0x17000015")]
			bool BJCNHNPOKHM
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			Vector3 BGKOODEMCPF
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			Camera OAAMDFAHDGE
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
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

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x59F9820", Offset = "0x59F8A20", VA = "0x1859F9820")]
			public ColorConfiguration(ParticleSystem LCNLFMCKBFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x672C1A0", Offset = "0x672B3A0", VA = "0x18672C1A0")]
			public void BKKFNBCAAJE(Color HMCAFGCGFJF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class CCAJJDCCFNN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
			public CCAJJDCCFNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x672C170", Offset = "0x672B370", VA = "0x18672C170")]
			internal void <SetRenderingEnabled>b__0(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class JACNOMGPJKM : IEnumerator<EGGPGCCKPCO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private EGGPGCCKPCO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private FDDHOMABJHP <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private EGGPGCCKPCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x871950", Offset = "0x870B50", VA = "0x180871950")]
			[DebuggerHidden]
			public JACNOMGPJKM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x672CFA0", Offset = "0x672C1A0", VA = "0x18672CFA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x672D640", Offset = "0x672C840", VA = "0x18672D640", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class NFKHIHIFIDN : IEnumerator<EGGPGCCKPCO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private EGGPGCCKPCO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private EGGPGCCKPCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x871950", Offset = "0x870B50", VA = "0x180871950")]
			[DebuggerHidden]
			public NFKHIHIFIDN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x672D680", Offset = "0x672C880", VA = "0x18672D680", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x672D740", Offset = "0x672C940", VA = "0x18672D740", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> GLODJFLDIAP;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<NDKBIHNDDMO> ALDALKIBLOA;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> ANDIBOPJAGF;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static LKGILLBEJEK MCFAIKNELND;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float AFMAAHCGIOM = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool NGIENPGONDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int PGCPKPBDEMI;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private MIBOCAFKAHH category;

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
		private ParticleSystem.MinMaxGradient[] PBEHKPDGCFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool BPIMPNFDNHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float NEMJBGAJNEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float MHAAOONBMNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform EHFFICIAODF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 OPPNBKANFEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 KDGHGNAFOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private IJCBDINCGPO NKAPCKLIIGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private LKGILLBEJEK BPOCADNHJEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool LMEJOOEAJFG;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static IEnumerable<PooledParticle> MPOBDKDPPGF
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6732660", Offset = "0x6731860", VA = "0x186732660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MIBOCAFKAHH LJAPIPECJHL
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7DECC0", Offset = "0x7DDEC0", VA = "0x1807DECC0")]
			get
			{
				return default(MIBOCAFKAHH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int ENBGGMMFHNH
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7DEBF0", Offset = "0x7DDDF0", VA = "0x1807DEBF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool OKNMIKICIOB
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6732350", Offset = "0x6731550", VA = "0x186732350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static int NICGPJNIMDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x67324E0", Offset = "0x67316E0", VA = "0x1867324E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected static bool FBMMHNCHHLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x672FB20", Offset = "0x672ED20", VA = "0x18672FB20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ParticleSystem PJDFDBNAFCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x75C710", Offset = "0x75B910", VA = "0x18075C710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7BB010", Offset = "0x7BA210", VA = "0x1807BB010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ParticleSystem[] ONMNKEDDACN
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7B43F0", Offset = "0x7B35F0", VA = "0x1807B43F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private ParticleSystemRenderer[] FCGAOJJEDCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6FB850", Offset = "0x6FAA50", VA = "0x1806FB850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x814E40", Offset = "0x814040", VA = "0x180814E40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private IJCBDINCGPO GGNPJIIFGOM
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xFF4690", Offset = "0xFF3890", VA = "0x180FF4690")]
			get
			{
				return default(IJCBDINCGPO);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x672FC60", Offset = "0x672EE60", VA = "0x18672FC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action LCEKJHMCFAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x67322B0", Offset = "0x67314B0", VA = "0x1867322B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x67326C0", Offset = "0x67318C0", VA = "0x1867326C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6731E50", Offset = "0x6731050", VA = "0x186731E50")]
		public static PooledParticle TryPlayPrefab(PooledParticle GDEKLMNKJBC, Vector3 INLGLHIPOMC, Quaternion HEGBBJCMANH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6731C60", Offset = "0x6730E60", VA = "0x186731C60")]
		public static PooledParticle TryPlayPrefab(PooledParticle GDEKLMNKJBC, Vector3 INLGLHIPOMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x67312D0", Offset = "0x67304D0", VA = "0x1867312D0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x672F050", Offset = "0x672E250", VA = "0x18672F050")]
		private void BGDIKJCEHKL(bool OBFHBDLKFPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x67300D0", Offset = "0x672F2D0", VA = "0x1867300D0")]
		[IteratorStateMachine(typeof(JACNOMGPJKM))]
		private static IEnumerator<EGGPGCCKPCO> MMBODCAMIJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x672F2C0", Offset = "0x672E4C0", VA = "0x18672F2C0")]
		private static void GKDBALFPFNK(Stopwatch LIJGJGIGLOD, Vector3 KDPAIIJHIJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x672FBB0", Offset = "0x672EDB0", VA = "0x18672FBB0")]
		private static int LFAHPLHHPHJ(PooledParticle BLFKABPCHLN, PooledParticle NPFMAENOPCH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x672F130", Offset = "0x672E330", VA = "0x18672F130")]
		private static int CICBKJOCDLD(MIBOCAFKAHH JNKJFJLJKNJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x672F790", Offset = "0x672E990", VA = "0x18672F790")]
		protected void JFGMIGPAJNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6730290", Offset = "0x672F490", VA = "0x186730290")]
		protected void OADFEPCEOBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x672EE10", Offset = "0x672E010", VA = "0x18672EE10", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x672FC80", Offset = "0x672EE80", VA = "0x18672FC80")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6730840", Offset = "0x672FA40", VA = "0x186730840")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x672F240", Offset = "0x672E440", VA = "0x18672F240")]
		[IteratorStateMachine(typeof(NFKHIHIFIDN))]
		private IEnumerator<EGGPGCCKPCO> FGFJDKMLINK(float FGBPJMKCMAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x672FF20", Offset = "0x672F120", VA = "0x18672FF20")]
		private void MBLNKLCECMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6731A70", Offset = "0x6730C70", VA = "0x186731A70")]
		public void SetDuration(float FGBPJMKCMAO, bool LNNMBGPOAJO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6730FB0", Offset = "0x67301B0", VA = "0x186730FB0")]
		public void Play(Transform BHGFGJJJAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6730990", Offset = "0x672FB90", VA = "0x186730990")]
		public void Play(Transform BHGFGJJJAOE, bool KNMILELNMFH, float FKLJAEGFEDK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6730AE0", Offset = "0x672FCE0", VA = "0x186730AE0")]
		public void Play(Transform BHGFGJJJAOE, Vector3 KDGHGNAFOFH, bool KNMILELNMFH, float FKLJAEGFEDK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6730D60", Offset = "0x672FF60", VA = "0x186730D60")]
		public void Play(Transform FPCCLKMHFBJ, Quaternion HEGBBJCMANH, bool KNMILELNMFH = false, float FKLJAEGFEDK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6730C30", Offset = "0x672FE30", VA = "0x186730C30")]
		public void Play(Transform FPCCLKMHFBJ, Vector3 KDGHGNAFOFH, Quaternion HEGBBJCMANH, bool KNMILELNMFH = false, float FKLJAEGFEDK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x67308C0", Offset = "0x672FAC0", VA = "0x1867308C0")]
		public void Play(Vector3 INLGLHIPOMC, Quaternion HEGBBJCMANH, Vector3 OIEPDFJCEHE, bool KNMILELNMFH = false, float FKLJAEGFEDK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x67310F0", Offset = "0x67302F0", VA = "0x1867310F0")]
		public void Play(Vector3 INLGLHIPOMC, Quaternion HEGBBJCMANH, bool KNMILELNMFH = false, float FKLJAEGFEDK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6730EA0", Offset = "0x67300A0", VA = "0x186730EA0")]
		public void Play(bool KNMILELNMFH = false, float FKLJAEGFEDK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6731BD0", Offset = "0x6730DD0", VA = "0x186731BD0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6731B40", Offset = "0x6730D40", VA = "0x186731B40")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x672F990", Offset = "0x672EB90", VA = "0x18672F990")]
		private void KAPALLIDOAL(float FGBPJMKCMAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6730120", Offset = "0x672F320", VA = "0x186730120")]
		private void NBKEKFHPOBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x67311B0", Offset = "0x67303B0", VA = "0x1867311B0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6731470", Offset = "0x6730670", VA = "0x186731470")]
		public void SetColor(Color HMCAFGCGFJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x672F650", Offset = "0x672E850", VA = "0x18672F650")]
		private void HFMBHLCJEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6732250", Offset = "0x6731450", VA = "0x186732250")]
		public PooledParticle()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NFLCIDIFMGO
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static byte[] OFIIJNPNABI;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static int AJJJCGJNNOF;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static int HJKCCLPHOML;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static BigInteger KJPEHCDEKDE;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NFLCIDIFMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x672D780", Offset = "0x672C980", VA = "0x18672D780")]
	private static string DHECIEFNHGE(byte[] EFNJCAIBDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x672D890", Offset = "0x672CA90", VA = "0x18672D890")]
	public static string EAFEFBMLFGD(byte[] ODBGNNDKAMK, bool MKOEKIGFDJD)
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

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
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
