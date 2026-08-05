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
		[Cpp2IlInjected.Address(RVA = "0x6201340", Offset = "0x6200140", VA = "0x186201340")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles CDFGDNNFDBC, float NCKEAPEFEDG, Vector3 MHFADBEELBD, Quaternion NJBEEEBFFMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6200FE0", Offset = "0x61FFDE0", VA = "0x186200FE0")]
		public void SetDamageValue(float NCKEAPEFEDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x62014C0", Offset = "0x62002C0", VA = "0x1862014C0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LJMBEMPGLMH<T> : FJJBNKADFNG<T>, PCFNKHPOHAG, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OAFLMDIDGDG<T> : PCFNKHPOHAG, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JFJIDDLMHPP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FHBBHGNFIEH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MNNAHJJLIIL<T> : PGNMDMMNJMF<T>, LJMBEMPGLMH<T>, FJJBNKADFNG<T>, PCFNKHPOHAG, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class CFJJMPHKGFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public MNNAHJJLIIL<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
			public CFJJMPHKGFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x47FEF10", Offset = "0x47FDD10", VA = "0x1847FEF10")]
			internal void MBBAJEHOCMN(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2F071C0", Offset = "0x2F05FC0", VA = "0x182F071C0")]
			internal void JHFGADKAJGN(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private INJGOFBOMAK<T> AOIMKAIANBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool EJGAPENMDHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T PICGAENFGAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool DNFKHDPAHCP;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3D945E0", Offset = "0x3D933E0", VA = "0x183D945E0")]
		public MNNAHJJLIIL(INJGOFBOMAK<T> AOIMKAIANBE, ObjectPool EJGAPENMDHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3D944A0", Offset = "0x3D932A0", VA = "0x183D944A0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class FOFFCJEGEMI<T> : EEELEBFPAJE, OAFLMDIDGDG<T>, PCFNKHPOHAG, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class NGBMDAMANIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public FOFFCJEGEMI<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
			public NGBMDAMANIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x3DF1480", Offset = "0x3DF0280", VA = "0x183DF1480")]
			internal void MBBAJEHOCMN(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9A1B20", Offset = "0x9A0920", VA = "0x1809A1B20")]
			internal void JHFGADKAJGN(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private INJGOFBOMAK<T> AOIMKAIANBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool DNFKHDPAHCP;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3623B70", Offset = "0x3622970", VA = "0x183623B70")]
		public FOFFCJEGEMI(INJGOFBOMAK<T> AOIMKAIANBE, ObjectPool EJGAPENMDHM, int OMONGNFLILJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3623B10", Offset = "0x3622910", VA = "0x183623B10", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NJICNHMMAMG<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public FHBBHGNFIEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public PGNMDMMNJMF<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public INJGOFBOMAK<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public NJICNHMMAMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9980", Offset = "0x3DF8780", VA = "0x183DF9980")]
		internal void KHLJKJAECBF(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9A30", Offset = "0x3DF8830", VA = "0x183DF9A30")]
		internal void PNJJGKEHCJG(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9930", Offset = "0x3DF8730", VA = "0x183DF9930")]
		internal void DFKBBPGGPHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<JFJIDDLMHPP> FCPNLMMDPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private BNALEBFPMEL CHPEGLANAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool EJGAPENMDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool DNFKHDPAHCP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool JIDLAOMFFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61FFBA0", Offset = "0x61FE9A0", VA = "0x1861FFBA0")]
	private static void PBJMPJPHODM(Component HFOAJNFAAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x61FFE70", Offset = "0x61FEC70", VA = "0x1861FFE70")]
	public FHBBHGNFIEH(string BGOCNLJJBDL, int FHCOAGEGLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x25B0B10", Offset = "0x25AF910", VA = "0x1825B0B10")]
	public LJMBEMPGLMH<T> KILMBPDMCDG<T>(AssetReference JKBOJPLBHBL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x25B0A60", Offset = "0x25AF860", VA = "0x1825B0A60")]
	public OAFLMDIDGDG<T> INMHKAHACCJ<T>(AssetReference JKBOJPLBHBL, int KGLOPMIHJGF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x25B0660", Offset = "0x25AF460", VA = "0x1825B0660")]
	public FJJBNKADFNG<bool> EHIDDDLCNJK<T>(AssetReference JKBOJPLBHBL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x61FF7F0", Offset = "0x61FE5F0", VA = "0x1861FF7F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x61FFA70", Offset = "0x61FE870", VA = "0x1861FFA70")]
	private void KDCDFPBMGDJ(UnityEngine.Object IJEKKHOFMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x61FF8E0", Offset = "0x61FE6E0", VA = "0x1861FF8E0")]
	private ObjectPool IBPJPLIDODJ(string BGOCNLJJBDL)
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
		private static GlobalPool GOBHOKLGPPK;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject ODMHCIFMIEI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool CEIKCOHBGGB
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x62005D0", Offset = "0x61FF3D0", VA = "0x1862005D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x25CB030", Offset = "0x25C9E30", VA = "0x1825CB030")]
		public static void SafeRelease<T>(T FGANJEAKCMA) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6200500", Offset = "0x61FF300", VA = "0x186200500")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x62005C0", Offset = "0x61FF3C0", VA = "0x1862005C0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, GNMMNINPCIB> EOCAGOOKNCE;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x27625D0", Offset = "0x27613D0", VA = "0x1827625D0")]
		public T Acquire<T>(T CDFGDNNFDBC, [Optional] Action<Component> HMKNMIFFJLN) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2762940", Offset = "0x2761740", VA = "0x182762940")]
		public bool Release<T>(T FGANJEAKCMA) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x27628F0", Offset = "0x27616F0", VA = "0x1827628F0")]
		public void Prefill<T>(T CDFGDNNFDBC, int JDHFMIAPKLG, [Optional] Action<Component> HMEOGEBHBJK) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2762710", Offset = "0x2761510", VA = "0x182762710")]
		public bool Exists<T>(T CDFGDNNFDBC) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2762660", Offset = "0x2761460", VA = "0x182762660")]
		public void Clear<T>(T CDFGDNNFDBC) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6200B80", Offset = "0x61FF980", VA = "0x186200B80")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x27627B0", Offset = "0x27615B0", VA = "0x1827627B0")]
		private GNMMNINPCIB PJFMJCKBCBP<T>(T CDFGDNNFDBC) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840")]
		public void TrackInstantiation(string NEDMICCGABK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840")]
		public void EnableStats(bool AIMJFFNCPAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6200CF0", Offset = "0x61FFAF0", VA = "0x186200CF0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class GNMMNINPCIB
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface AINCIEHDDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GEEADCFNBIN(bool ICFPGIIEFOD);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string BAAGNNPAEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int NHMNFKFJJPL
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void INMHKAHACCJ(int KGLOPMIHJGF, Action<Component> HMEOGEBHBJK);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component KILMBPDMCDG(Action<Component> HMKNMIFFJLN);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool ENHCKFGAJIO(Component ELCNNAHJPKC);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void LJNFEICKFHE();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6200380", Offset = "0x61FF180", VA = "0x186200380")]
	protected void NMJABLBJDDF(Component FGANJEAKCMA, bool ICFPGIIEFOD, bool IAMEHAAHADG, bool HBGBBNNLEMD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6200100", Offset = "0x61FEF00", VA = "0x186200100")]
	protected void HMAEPEGKEDP(Transform GFGGAEKBOAN, bool ICFPGIIEFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	protected GNMMNINPCIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JMLAEFDECMA<T> : GNMMNINPCIB where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T CDFGDNNFDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool MJPDPONAFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool IAMEHAAHADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> DDNKGPHPOLH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string BAAGNNPAEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3A40DD0", Offset = "0x3A3FBD0", VA = "0x183A40DD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int NHMNFKFJJPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3A40AE0", Offset = "0x3A3F8E0", VA = "0x183A40AE0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3A41240", Offset = "0x3A40040", VA = "0x183A41240")]
	public JMLAEFDECMA(T CDFGDNNFDBC, ObjectPool MJPDPONAFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3A40CC0", Offset = "0x3A3FAC0", VA = "0x183A40CC0", Slot = "6")]
	public override void INMHKAHACCJ(int KGLOPMIHJGF, Action<Component> HMKNMIFFJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3A40DF0", Offset = "0x3A3FBF0", VA = "0x183A40DF0", Slot = "7")]
	public override Component KILMBPDMCDG(Action<Component> HMKNMIFFJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3A40B20", Offset = "0x3A3F920", VA = "0x183A40B20", Slot = "8")]
	public override bool ENHCKFGAJIO(Component ELCNNAHJPKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3A41060", Offset = "0x3A3FE60", VA = "0x183A41060", Slot = "9")]
	public override void LJNFEICKFHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3A40970", Offset = "0x3A3F770", VA = "0x183A40970")]
	private T BFICKFCDONB()
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
		public interface PPNOBGCMCEF
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject MPNKHFKBILL
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
		[Cpp2IlInjected.Address(RVA = "0x6200800", Offset = "0x61FF600", VA = "0x186200800")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6200AF0", Offset = "0x61FF8F0", VA = "0x186200AF0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool GOBHOKLGPPK;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject ODMHCIFMIEI;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool CEIKCOHBGGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6200E40", Offset = "0x61FFC40", VA = "0x186200E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6200D80", Offset = "0x61FFB80", VA = "0x186200D80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x62005C0", Offset = "0x61FF3C0", VA = "0x1862005C0")]
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
		public GNMMNINPCIB PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x790830", Offset = "0x78F630", VA = "0x180790830")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NELKOEGAGMD
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JOHKEINEOKI(PooledParticle.LBEBOLDFCHM CNIGIDNLJLF);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum LHDJCNGHJNL
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
		public enum LBEBOLDFCHM
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
		public interface HELBDIFPFKA
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool COKPCOJNGGG
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 PGLFJABOHEF
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera AGMIDEDEBLH
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
			[Cpp2IlInjected.Address(RVA = "0x5255980", Offset = "0x5254780", VA = "0x185255980")]
			public ColorConfiguration(ParticleSystem NDIKDCEDCBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x61FEF70", Offset = "0x61FDD70", VA = "0x1861FEF70")]
			public void HOBIFGOPLFH(Color PIPDACHFJNO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class ELCOBOODGAG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
			public ELCOBOODGAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x61FF7C0", Offset = "0x61FE5C0", VA = "0x1861FF7C0")]
			internal void KLMIJLHCCGH(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class EFCLEKFLOKK : IEnumerator<EFMJLGFKALI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private EFMJLGFKALI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private HELBDIFPFKA <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private EFMJLGFKALI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
			[DebuggerHidden]
			public EFCLEKFLOKK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x61FF160", Offset = "0x61FDF60", VA = "0x1861FF160", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x61FF770", Offset = "0x61FE570", VA = "0x1861FF770", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class MPGPAAAKMGP : IEnumerator<EFMJLGFKALI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private EFMJLGFKALI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private EFMJLGFKALI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
			[DebuggerHidden]
			public MPGPAAAKMGP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6200740", Offset = "0x61FF540", VA = "0x186200740", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x62007B0", Offset = "0x61FF5B0", VA = "0x1862007B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> EGHNEJJLCKN;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<NELKOEGAGMD> NPBDJEKHGIA;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> AAILPDKACKO;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static KPDMKFJCEFL IMKPPOPEILA;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float LIFINGDPLMP = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool NGNNBDMKEKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int IFOILIHEPBP;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private LBEBOLDFCHM category;

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
		private ParticleSystem.MinMaxGradient[] PCEDHEJJIGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool OHGCPOLCLOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float DDJHCNMKLLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float FNNBKGLEMHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform ONOEPBKHFIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 MILPGEFODBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 EJOPFJBAMMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private LHDJCNGHJNL COOKEJGBMAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private KPDMKFJCEFL LLNGAFOFFMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool JBDAMHFDKAK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> OAOBFNKHPDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6204D10", Offset = "0x6203B10", VA = "0x186204D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public LBEBOLDFCHM DGCCOENLPPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7B6700", Offset = "0x7B5500", VA = "0x1807B6700")]
			get
			{
				return default(LBEBOLDFCHM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int PNANGOHHFMA
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7944A0", Offset = "0x7932A0", VA = "0x1807944A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool CPKLFKPMELH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6204A40", Offset = "0x6203840", VA = "0x186204A40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int POLHACEOGLH
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6204BC0", Offset = "0x62039C0", VA = "0x186204BC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool LFDEOJELOKK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6202F20", Offset = "0x6201D20", VA = "0x186202F20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem GGEGNAJHADP
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x78E2A0", Offset = "0x78D0A0", VA = "0x18078E2A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x795720", Offset = "0x794520", VA = "0x180795720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] EIKAEMHDLHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x78E270", Offset = "0x78D070", VA = "0x18078E270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7944B0", Offset = "0x7932B0", VA = "0x1807944B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] GDMIOJHDMKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x78DFA0", Offset = "0x78CDA0", VA = "0x18078DFA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x78E1D0", Offset = "0x78CFD0", VA = "0x18078E1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private LHDJCNGHJNL PLMNKAPLJEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xDDAE90", Offset = "0xDD9C90", VA = "0x180DDAE90")]
			get
			{
				return default(LHDJCNGHJNL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x62016D0", Offset = "0x62004D0", VA = "0x1862016D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action GPGEAILKFDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x62049A0", Offset = "0x62037A0", VA = "0x1862049A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6204D60", Offset = "0x6203B60", VA = "0x186204D60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6204330", Offset = "0x6203130", VA = "0x186204330")]
		public static PooledParticle TryPlayPrefab(PooledParticle CDFGDNNFDBC, Vector3 MHFADBEELBD, Quaternion NJBEEEBFFMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x62044A0", Offset = "0x62032A0", VA = "0x1862044A0")]
		public static PooledParticle TryPlayPrefab(PooledParticle CDFGDNNFDBC, Vector3 MHFADBEELBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x62039E0", Offset = "0x62027E0", VA = "0x1862039E0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x62027C0", Offset = "0x62015C0", VA = "0x1862027C0")]
		private void MPOGFDCIAAO(bool PIDMEIKGKKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x62021A0", Offset = "0x6200FA0", VA = "0x1862021A0")]
		[IteratorStateMachine(typeof(EFCLEKFLOKK))]
		private static IEnumerator<EFMJLGFKALI> KBHDMBJHGEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6202200", Offset = "0x6201000", VA = "0x186202200")]
		private static void KJJPOIGIHIG(Stopwatch LJNGGJLINNI, Vector3 NFDCJCENOCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6201E50", Offset = "0x6200C50", VA = "0x186201E50")]
		private static int HPLGLIDJMJP(PooledParticle LBKCGMCBJAD, PooledParticle LEFACNCEBHI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6202090", Offset = "0x6200E90", VA = "0x186202090")]
		private static int JOHKEINEOKI(LBEBOLDFCHM CNIGIDNLJLF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x62019B0", Offset = "0x62007B0", VA = "0x1862019B0")]
		protected void BDIIONAOKIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6202890", Offset = "0x6201690", VA = "0x186202890")]
		protected void NLMDKEDIGCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6201780", Offset = "0x6200580", VA = "0x186201780", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6202550", Offset = "0x6201350", VA = "0x186202550")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6202EA0", Offset = "0x6201CA0", VA = "0x186202EA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x62016F0", Offset = "0x62004F0", VA = "0x1862016F0")]
		[IteratorStateMachine(typeof(MPGPAAAKMGP))]
		private IEnumerator<EFMJLGFKALI> ANACMOJICNC(float OGMFDJJPFIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6201CF0", Offset = "0x6200AF0", VA = "0x186201CF0")]
		private void ENHCKFGAJIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6204140", Offset = "0x6202F40", VA = "0x186204140")]
		public void SetDuration(float OGMFDJJPFIB, bool LIKCNGCHILO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6202FA0", Offset = "0x6201DA0", VA = "0x186202FA0")]
		public void Play(Transform HENFOMPDJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6203650", Offset = "0x6202450", VA = "0x186203650")]
		public void Play(Transform HENFOMPDJLC, bool LIBNGNFCKKO, float HGKIEMHEGJG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6203100", Offset = "0x6201F00", VA = "0x186203100")]
		public void Play(Transform HENFOMPDJLC, Vector3 EJOPFJBAMMM, bool LIBNGNFCKKO, float HGKIEMHEGJG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6203250", Offset = "0x6202050", VA = "0x186203250")]
		public void Play(Transform BGHGEFDECJJ, Quaternion NJBEEEBFFMP, bool LIBNGNFCKKO = false, float HGKIEMHEGJG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x62037C0", Offset = "0x62025C0", VA = "0x1862037C0")]
		public void Play(Transform BGHGEFDECJJ, Vector3 EJOPFJBAMMM, Quaternion NJBEEEBFFMP, bool LIBNGNFCKKO = false, float HGKIEMHEGJG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6203470", Offset = "0x6202270", VA = "0x186203470")]
		public void Play(Vector3 MHFADBEELBD, Quaternion NJBEEEBFFMP, Vector3 IBOAKNMBPHJ, bool LIBNGNFCKKO = false, float HGKIEMHEGJG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x62033B0", Offset = "0x62021B0", VA = "0x1862033B0")]
		public void Play(Vector3 MHFADBEELBD, Quaternion NJBEEEBFFMP, bool LIBNGNFCKKO = false, float HGKIEMHEGJG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6203540", Offset = "0x6202340", VA = "0x186203540")]
		public void Play(bool LIBNGNFCKKO = false, float HGKIEMHEGJG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x62042A0", Offset = "0x62030A0", VA = "0x1862042A0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6204210", Offset = "0x6203010", VA = "0x186204210")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6201F00", Offset = "0x6200D00", VA = "0x186201F00")]
		private void JMCFKJHELEC(float OGMFDJJPFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6201BB0", Offset = "0x62009B0", VA = "0x186201BB0")]
		private void CABBJHHDCFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x62038F0", Offset = "0x62026F0", VA = "0x1862038F0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6203B60", Offset = "0x6202960", VA = "0x186203B60")]
		public void SetColor(Color PIPDACHFJNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x62015A0", Offset = "0x62003A0", VA = "0x1862015A0")]
		private void ACLHFDBJOCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6204910", Offset = "0x6203710", VA = "0x186204910")]
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
