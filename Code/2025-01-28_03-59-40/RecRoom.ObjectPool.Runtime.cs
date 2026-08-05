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
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private float minDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float maxDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Header("Impact Particle System")]
		[SerializeField]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		[Header("Impact Particle Start Size")]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Header("Impact Particle Start Lifetime")]
		[SerializeField]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Header("Spray Particle System")]
		[SerializeField]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Spray Particle Burst Count")]
		[SerializeField]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x74FCA80", Offset = "0x74FBC80", VA = "0x1874FCA80")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles CJAMBKAOMGP, float IEKHILLIPKL, Vector3 FCKJMOMOHAE, Quaternion EGIHDGHICMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x74FC720", Offset = "0x74FB920", VA = "0x1874FC720")]
		public void SetDamageValue(float IEKHILLIPKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x74FCC50", Offset = "0x74FBE50", VA = "0x1874FCC50")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PLJKPBMHFFN<T> : OABBPFFKNOC<T>, JABNAOPJDOK, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CAMANMKODBL<T> : JABNAOPJDOK, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JNCGNJCMJJL
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ALBINDBAGEO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class JBNGAMDBGAE<T> : ONKLLOPAHFE<T>, PLJKPBMHFFN<T>, OABBPFFKNOC<T>, JABNAOPJDOK, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IAPMAKJKDEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public JBNGAMDBGAE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public IAPMAKJKDEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x45A7280", Offset = "0x45A6480", VA = "0x1845A7280")]
			internal void PPJPMAAMDBO(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x32BFBC0", Offset = "0x32BEDC0", VA = "0x1832BFBC0")]
			internal void JONDHBOEEGN(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private PDBMJMIDPNE<T> FMNBOMGNGFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool NGCKMPIMHKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T IEFGENALBBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool HAOFCOOGPMB;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x481A310", Offset = "0x4819510", VA = "0x18481A310")]
		public JBNGAMDBGAE(PDBMJMIDPNE<T> FMNBOMGNGFB, ObjectPool NGCKMPIMHKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x481A1A0", Offset = "0x48193A0", VA = "0x18481A1A0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class EBBPJMDCKLH<T> : LIKAJDLHHFB, CAMANMKODBL<T>, JABNAOPJDOK, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class LPBPNHDFNOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public EBBPJMDCKLH<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public LPBPNHDFNOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x4A0F160", Offset = "0x4A0E360", VA = "0x184A0F160")]
			internal void PPJPMAAMDBO(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x11CE130", Offset = "0x11CD330", VA = "0x1811CE130")]
			internal void JONDHBOEEGN(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private PDBMJMIDPNE<T> FMNBOMGNGFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool HAOFCOOGPMB;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE870", Offset = "0x3ECDA70", VA = "0x183ECE870")]
		public EBBPJMDCKLH(PDBMJMIDPNE<T> FMNBOMGNGFB, ObjectPool NGCKMPIMHKK, int AEJHNAALMGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE810", Offset = "0x3ECDA10", VA = "0x183ECE810", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CCIOCOAMIJO<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public ALBINDBAGEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ONKLLOPAHFE<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public PDBMJMIDPNE<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public CCIOCOAMIJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x56E2E00", Offset = "0x56E2000", VA = "0x1856E2E00")]
		internal void LGCLKGCCEBH(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x56E2EB0", Offset = "0x56E20B0", VA = "0x1856E2EB0")]
		internal void LNCCLMADIEF(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x56E2DB0", Offset = "0x56E1FB0", VA = "0x1856E2DB0")]
		internal void GLPKDEFHBDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<JNCGNJCMJJL> OINHHONBHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private AAAHBAIDKON PIPKIDBJEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool NGCKMPIMHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool HAOFCOOGPMB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x74FAA40", Offset = "0x74F9C40", VA = "0x1874FAA40")]
	private static void NOJOIEPFILI(Component DMLGABHGKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x74FAD20", Offset = "0x74F9F20", VA = "0x1874FAD20")]
	public ALBINDBAGEO(string ECOGHLMLONM, int LGIDMNANELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x39EFEC0", Offset = "0x39EF0C0", VA = "0x1839EFEC0")]
	public PLJKPBMHFFN<T> HFPCILCLDOM<T>(AssetReference ABLPLMMMMIL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x39EFF90", Offset = "0x39EF190", VA = "0x1839EFF90")]
	public CAMANMKODBL<T> HNAGNBDIIKN<T>(AssetReference ABLPLMMMMIL, int EOKNBJLIKEG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x39F0070", Offset = "0x39EF270", VA = "0x1839F0070")]
	public OABBPFFKNOC<bool> KIFOFJDPIIL<T>(AssetReference ABLPLMMMMIL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x74FA670", Offset = "0x74F9870", VA = "0x1874FA670", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x74FA760", Offset = "0x74F9960", VA = "0x1874FA760")]
	private void JLABLNLDLPC(UnityEngine.Object JHCEGFJOEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x74FA8B0", Offset = "0x74F9AB0", VA = "0x1874FA8B0")]
	private ObjectPool NLHMPKDECIK(string ECOGHLMLONM)
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
		private static GlobalPool MPLLIJODNLK;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject NBFKMGKMFFI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool CLACNPDFIIL
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x74FB9D0", Offset = "0x74FABD0", VA = "0x1874FB9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3280BC0", Offset = "0x327FDC0", VA = "0x183280BC0")]
		public static void SafeRelease<T>(T LCACGJDNDHA) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x74FB900", Offset = "0x74FAB00", VA = "0x1874FB900")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x74FB9C0", Offset = "0x74FABC0", VA = "0x1874FB9C0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, IBOEIPLAANG> GOBBCBOBJKN;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3453280", Offset = "0x3452480", VA = "0x183453280")]
		public T Acquire<T>(T CJAMBKAOMGP, [Optional] Action<Component> NBFBBAINHJN) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3453640", Offset = "0x3452840", VA = "0x183453640")]
		public bool Release<T>(T LCACGJDNDHA) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x34535D0", Offset = "0x34527D0", VA = "0x1834535D0")]
		public void Prefill<T>(T CJAMBKAOMGP, int FJEGNMPCGGG, [Optional] Action<Component> NFNIAIPFJGF) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x34533F0", Offset = "0x34525F0", VA = "0x1834533F0")]
		public bool Exists<T>(T CJAMBKAOMGP) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3453340", Offset = "0x3452540", VA = "0x183453340")]
		public void Clear<T>(T CJAMBKAOMGP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x74FC2C0", Offset = "0x74FB4C0", VA = "0x1874FC2C0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3453490", Offset = "0x3452690", VA = "0x183453490")]
		private IBOEIPLAANG KOBAJJHHGJG<T>(T CJAMBKAOMGP) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
		public void TrackInstantiation(string DNABECDMHDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
		public void EnableStats(bool LHNBACCEOHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x74FC430", Offset = "0x74FB630", VA = "0x1874FC430")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class IBOEIPLAANG
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FGAAONGPGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HFHILEIMLBG(bool CICEJGGDGEC);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string PCMLNMEPCBI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int JBECHGIAPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void HNAGNBDIIKN(int EOKNBJLIKEG, Action<Component> NFNIAIPFJGF);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component HFPCILCLDOM(Action<Component> NBFBBAINHJN);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool OIHANPNKAFH(Component GMGJNFEBMOH);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void DBGBEIOBMKO();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x74FBDC0", Offset = "0x74FAFC0", VA = "0x1874FBDC0")]
	protected void ONHPNCKADND(Component LCACGJDNDHA, bool CICEJGGDGEC, bool LBMLAMOLLAK, bool AOEGEMKDNHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x74FBB40", Offset = "0x74FAD40", VA = "0x1874FBB40")]
	protected void DFFLFJLKAAD(Transform KKEJFMIAAOE, bool CICEJGGDGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	protected IBOEIPLAANG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class BAMBMAHGBND<T> : IBOEIPLAANG where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T CJAMBKAOMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool PIGFABIBHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool LBMLAMOLLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> DMCEBBKEEFK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string PCMLNMEPCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5630F00", Offset = "0x5630100", VA = "0x185630F00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int JBECHGIAPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5631130", Offset = "0x5630330", VA = "0x185631130", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5631870", Offset = "0x5630A70", VA = "0x185631870")]
	public BAMBMAHGBND(T CJAMBKAOMGP, ObjectPool PIGFABIBHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5631410", Offset = "0x5630610", VA = "0x185631410", Slot = "6")]
	public override void HNAGNBDIIKN(int EOKNBJLIKEG, Action<Component> NBFBBAINHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5631180", Offset = "0x5630380", VA = "0x185631180", Slot = "7")]
	public override Component HFPCILCLDOM(Action<Component> NBFBBAINHJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x56316C0", Offset = "0x56308C0", VA = "0x1856316C0", Slot = "8")]
	public override bool OIHANPNKAFH(Component GMGJNFEBMOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5630F20", Offset = "0x5630120", VA = "0x185630F20", Slot = "9")]
	public override void DBGBEIOBMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5631540", Offset = "0x5630740", VA = "0x185631540")]
	private T OIBLJPGPLIE()
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
		public interface MDOAGJLBOGL
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject HPLEDKLLMBN
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
		[Cpp2IlInjected.Address(RVA = "0x74FBF40", Offset = "0x74FB140", VA = "0x1874FBF40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x74FC230", Offset = "0x74FB430", VA = "0x1874FC230")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool MPLLIJODNLK;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject NBFKMGKMFFI;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool CLACNPDFIIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x74FC580", Offset = "0x74FB780", VA = "0x1874FC580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x74FC4C0", Offset = "0x74FB6C0", VA = "0x1874FC4C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x74FB9C0", Offset = "0x74FABC0", VA = "0x1874FB9C0")]
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
		public IBOEIPLAANG PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IMLLJIOODON
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LDEPCDDJHCF(PooledParticle.CPCILCMLIHG ODGIEDCAFMF);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum DFKBNPDNOMB
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum CPCILCMLIHG
		{
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public interface KINEIOHJELA
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool FPIMEJONMLO
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 NNDLCJDKKEC
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera AIBPIKKKAKG
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
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6340580", Offset = "0x633F780", VA = "0x186340580")]
			public ColorConfiguration(ParticleSystem EBIPIDBMDIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x74FB6E0", Offset = "0x74FA8E0", VA = "0x1874FB6E0")]
			public void ODKFIKLPJFB(Color HCHFCFNLIAI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class GHKMNNNDPAM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public GHKMNNNDPAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x74FB8D0", Offset = "0x74FAAD0", VA = "0x1874FB8D0")]
			internal void EKEBOBOENIG(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class BNBCFCKMMAE : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private IOBGCLDPPJE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private KINEIOHJELA <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
			[DebuggerHidden]
			public BNBCFCKMMAE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x74FB070", Offset = "0x74FA270", VA = "0x1874FB070", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x74FB690", Offset = "0x74FA890", VA = "0x1874FB690", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class BHBPEIKKPJD : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private IOBGCLDPPJE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
			[DebuggerHidden]
			public BHBPEIKKPJD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x74FAFB0", Offset = "0x74FA1B0", VA = "0x1874FAFB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x74FB020", Offset = "0x74FA220", VA = "0x1874FB020", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> HICFPPDJDBP;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<IMLLJIOODON> PFIFHCLBJGE;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> EIFKALPNOAL;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static GFDHFLBBFKF GPCJKNIJAIA;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float BGIFOPGGAJM = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool AICCCDBCPKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int HPHLGCFBPGL;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private CPCILCMLIHG category;

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
		private ParticleSystem.MinMaxGradient[] DLAMAMLNNOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool PMMMIDEPBMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float FAAPFNHJHKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float HIKBKMNJCNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform KOFKDGKMPLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 INPHMPLBIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 FCJJBONPNIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private DFKBNPDNOMB MNPHBFGAEPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private GFDHFLBBFKF AEJIHOMPNOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool MIHEAIKDCCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Transform FGKHLIDOOPC;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> MNOLKDEFAMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x75007D0", Offset = "0x74FF9D0", VA = "0x1875007D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public CPCILCMLIHG MGOPGAMFKLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x91B6D0", Offset = "0x91A8D0", VA = "0x18091B6D0")]
			get
			{
				return default(CPCILCMLIHG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int FCCFPEFCKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D30", Offset = "0x8F3F30", VA = "0x1808F4D30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MEJCLCCDGDO
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7500500", Offset = "0x74FF700", VA = "0x187500500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int CHBAOEIHOMB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7500680", Offset = "0x74FF880", VA = "0x187500680")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool OMLDDABKIED
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x74FD340", Offset = "0x74FC540", VA = "0x1874FD340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem OFKBHKFIMHI
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8F85C0", Offset = "0x8F77C0", VA = "0x1808F85C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] HIMHBAMEOEI
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D20", Offset = "0x8F3F20", VA = "0x1808F4D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D40", Offset = "0x8F3F40", VA = "0x1808F4D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] BPLEFJFCMHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0E0", Offset = "0x8FA2E0", VA = "0x1808FB0E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0C0", Offset = "0x8FA2C0", VA = "0x1808FB0C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private DFKBNPDNOMB FJBFBCPIDJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAC7780", Offset = "0xAC6980", VA = "0x180AC7780")]
			get
			{
				return default(DFKBNPDNOMB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x74FE050", Offset = "0x74FD250", VA = "0x1874FE050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Transform MCPAEAAAAAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7500820", Offset = "0x74FFA20", VA = "0x187500820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action KCFJLKGBCGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7500460", Offset = "0x74FF660", VA = "0x187500460")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7500870", Offset = "0x74FFA70", VA = "0x187500870")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x74FFD60", Offset = "0x74FEF60", VA = "0x1874FFD60")]
		public static PooledParticle TryPlayPrefab(PooledParticle CJAMBKAOMGP, Vector3 FCKJMOMOHAE, Quaternion EGIHDGHICMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x74FFF10", Offset = "0x74FF110", VA = "0x1874FFF10")]
		public static PooledParticle TryPlayPrefab(PooledParticle CJAMBKAOMGP, Vector3 FCKJMOMOHAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x74FF420", Offset = "0x74FE620", VA = "0x1874FF420")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x74FD3C0", Offset = "0x74FC5C0", VA = "0x1874FD3C0")]
		private void FCHEHCNHAAC(bool FOFAGPDFKME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x74FDAC0", Offset = "0x74FCCC0", VA = "0x1874FDAC0")]
		[IteratorStateMachine(typeof(BNBCFCKMMAE))]
		private static IEnumerator<IOBGCLDPPJE> FHDGCMMNJMB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x74FE1D0", Offset = "0x74FD3D0", VA = "0x1874FE1D0")]
		private static void OJOACOLAFGK(Stopwatch FBHOIGDCPGK, Vector3 MJFIMEONFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x74FCD30", Offset = "0x74FBF30", VA = "0x1874FCD30")]
		private static int APEIOEFCHDJ(PooledParticle FBCBJPMNPEK, PooledParticle HHDMEFHBCOI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x74FDB20", Offset = "0x74FCD20", VA = "0x1874FDB20")]
		private static int LDEPCDDJHCF(CPCILCMLIHG ODGIEDCAFMF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x74FD140", Offset = "0x74FC340", VA = "0x1874FD140")]
		protected void CEKBEGPMHNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x74FD490", Offset = "0x74FC690", VA = "0x1874FD490")]
		protected void FCMGOAHFNGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x74FCDE0", Offset = "0x74FBFE0", VA = "0x1874FCDE0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x74FDD70", Offset = "0x74FCF70", VA = "0x1874FDD70")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x74FE540", Offset = "0x74FD740", VA = "0x1874FE540")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x74FE5C0", Offset = "0x74FD7C0", VA = "0x1874FE5C0")]
		[IteratorStateMachine(typeof(BHBPEIKKPJD))]
		private IEnumerator<IOBGCLDPPJE> PAPBHLELJDO(float NHFPPHNGOPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x74FE070", Offset = "0x74FD270", VA = "0x1874FE070")]
		private void OIHANPNKAFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x74FFB70", Offset = "0x74FED70", VA = "0x1874FFB70")]
		public void SetDuration(float NHFPPHNGOPH, bool NLFGFIMHICK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x74FE7E0", Offset = "0x74FD9E0", VA = "0x1874FE7E0")]
		public void Play(Transform BPBICFDEOPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x74FEFF0", Offset = "0x74FE1F0", VA = "0x1874FEFF0")]
		public void Play(Transform BPBICFDEOPP, bool AEKPGGBHEDP, float FLLCBJJCDAA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x74FE980", Offset = "0x74FDB80", VA = "0x1874FE980")]
		public void Play(Transform BPBICFDEOPP, Vector3 FCJJBONPNIA, bool AEKPGGBHEDP, float FLLCBJJCDAA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x74FEB10", Offset = "0x74FDD10", VA = "0x1874FEB10")]
		public void Play(Transform PCGBJCFHBFK, Quaternion EGIHDGHICMO, bool AEKPGGBHEDP = false, float FLLCBJJCDAA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x74FF1B0", Offset = "0x74FE3B0", VA = "0x1874FF1B0")]
		public void Play(Transform PCGBJCFHBFK, Vector3 FCJJBONPNIA, Quaternion EGIHDGHICMO, bool AEKPGGBHEDP = false, float FLLCBJJCDAA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x74FEDC0", Offset = "0x74FDFC0", VA = "0x1874FEDC0")]
		public void Play(Vector3 FCKJMOMOHAE, Quaternion EGIHDGHICMO, Vector3 BEIJOKHFPBB, bool AEKPGGBHEDP = false, float FLLCBJJCDAA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x74FECC0", Offset = "0x74FDEC0", VA = "0x1874FECC0")]
		public void Play(Vector3 FCKJMOMOHAE, Quaternion EGIHDGHICMO, bool AEKPGGBHEDP = false, float FLLCBJJCDAA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x74FEEE0", Offset = "0x74FE0E0", VA = "0x1874FEEE0")]
		public void Play(bool AEKPGGBHEDP = false, float FLLCBJJCDAA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x74FFCD0", Offset = "0x74FEED0", VA = "0x1874FFCD0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x74FFC40", Offset = "0x74FEE40", VA = "0x1874FFC40")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x74FE650", Offset = "0x74FD850", VA = "0x1874FE650")]
		private void PKADMLLNDGP(float NHFPPHNGOPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x74FDC30", Offset = "0x74FCE30", VA = "0x1874FDC30")]
		private void LOKGOKDNKBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x74FF330", Offset = "0x74FE530", VA = "0x1874FF330")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x74FF5A0", Offset = "0x74FE7A0", VA = "0x1874FF5A0")]
		public void SetColor(Color HCHFCFNLIAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x74FD010", Offset = "0x74FC210", VA = "0x1874FD010")]
		private void BAJBAIEGBLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x75003D0", Offset = "0x74FF5D0", VA = "0x1875003D0")]
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
