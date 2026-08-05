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
		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private float minDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float maxDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Header("Impact Particle System")]
		[SerializeField]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Header("Impact Particle Start Size")]
		[SerializeField]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Header("Impact Particle Start Lifetime")]
		[SerializeField]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Header("Spray Particle System")]
		[SerializeField]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Spray Particle Burst Count")]
		[SerializeField]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7797670", Offset = "0x7796A70", VA = "0x187797670")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles CFENBMBECBB, float AOGBFMICMMM, Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7797310", Offset = "0x7796710", VA = "0x187797310")]
		public void SetDamageValue(float AOGBFMICMMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x77977B0", Offset = "0x7796BB0", VA = "0x1877977B0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PFADGFBHMAK<T> : NEEPBAPEEOL<T>, HJOKANJAKGB, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BCMNJBBOGDC<T> : HJOKANJAKGB, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EGPIMOBBEJO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JOLJKKFGKEN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HBPFHPJGKFD<T> : NINOOKDCBLL<T>, PFADGFBHMAK<T>, NEEPBAPEEOL<T>, HJOKANJAKGB, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class HAMGMEICDOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public HBPFHPJGKFD<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public HAMGMEICDOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4591020", Offset = "0x4590420", VA = "0x184591020")]
			internal void MMFIKBIHOOK(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3410ED0", Offset = "0x34102D0", VA = "0x183410ED0")]
			internal void BIBMCJOGPJP(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private EBHOPDBMNPK<T> NGHJKODNPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool JFNIOBJOEJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T AIHLLHKMGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool NLNPPHMOFNH;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x45CB3B0", Offset = "0x45CA7B0", VA = "0x1845CB3B0")]
		public HBPFHPJGKFD(EBHOPDBMNPK<T> NGHJKODNPLB, ObjectPool JFNIOBJOEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x45CB1D0", Offset = "0x45CA5D0", VA = "0x1845CB1D0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class NHLCIMJDOOG<T> : NKJHMBFDFON, BCMNJBBOGDC<T>, HJOKANJAKGB, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class FMOBGEJIABE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public NHLCIMJDOOG<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public FMOBGEJIABE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x43DD160", Offset = "0x43DC560", VA = "0x1843DD160")]
			internal void MMFIKBIHOOK(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x11F2CF0", Offset = "0x11F20F0", VA = "0x1811F2CF0")]
			internal void BIBMCJOGPJP(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private EBHOPDBMNPK<T> NGHJKODNPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool NLNPPHMOFNH;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4E33EA0", Offset = "0x4E332A0", VA = "0x184E33EA0")]
		public NHLCIMJDOOG(EBHOPDBMNPK<T> NGHJKODNPLB, ObjectPool JFNIOBJOEJO, int PEHMKNBLLOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4E33E40", Offset = "0x4E33240", VA = "0x184E33E40", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class EKPMHPEEKOI<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public JOLJKKFGKEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public NINOOKDCBLL<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public EBHOPDBMNPK<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public EKPMHPEEKOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x401EC80", Offset = "0x401E080", VA = "0x18401EC80")]
		internal void KMIAKMNBGGG(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x401EBD0", Offset = "0x401DFD0", VA = "0x18401EBD0")]
		internal void ANPAPOGGFDC(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x401EC30", Offset = "0x401E030", VA = "0x18401EC30")]
		internal void GOABJGCGOBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<EGPIMOBBEJO> JFKLCAAHNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private DOMGDKAEFND MEGLEFPMALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool JFNIOBJOEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool NLNPPHMOFNH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7795A80", Offset = "0x7794E80", VA = "0x187795A80")]
	private static void PAKMMOGIOJL(Component MEFMJJOMDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7795D60", Offset = "0x7795160", VA = "0x187795D60")]
	public JOLJKKFGKEN(string BPDGMLOBIKL, int FDIHOEFFEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x34296F0", Offset = "0x3428AF0", VA = "0x1834296F0")]
	public PFADGFBHMAK<T> OCHIEBOHGDJ<T>(AssetReference LLFKBAMNPDC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3429610", Offset = "0x3428A10", VA = "0x183429610")]
	public BCMNJBBOGDC<T> GLCLOAHEKFN<T>(AssetReference LLFKBAMNPDC, int BBEJNKBNMID) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x34291F0", Offset = "0x34285F0", VA = "0x1834291F0")]
	public NEEPBAPEEOL<bool> GAJJJBGADKG<T>(AssetReference LLFKBAMNPDC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x77956B0", Offset = "0x7794AB0", VA = "0x1877956B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7795930", Offset = "0x7794D30", VA = "0x187795930")]
	private void IGGEEKNJNIM(UnityEngine.Object NCAHJLMHIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x77957A0", Offset = "0x7794BA0", VA = "0x1877957A0")]
	private ObjectPool ENCBGCDEMGP(string BPDGMLOBIKL)
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
		private static GlobalPool NHILJKJCKFJ;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject GEJHFIAODAN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool IMFIEPMCPDC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7795540", Offset = "0x7794940", VA = "0x187795540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x339FCE0", Offset = "0x339F0E0", VA = "0x18339FCE0")]
		public static void SafeRelease<T>(T GMFKPONAANG) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7795470", Offset = "0x7794870", VA = "0x187795470")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7795530", Offset = "0x7794930", VA = "0x187795530")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, LLAJJNPCMIF> BCOCOAJJHMM;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x35B9870", Offset = "0x35B8C70", VA = "0x1835B9870")]
		public T Acquire<T>(T CFENBMBECBB, [Optional] Action<Component> BPDNFEKELGB) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x35B9C30", Offset = "0x35B9030", VA = "0x1835B9C30")]
		public bool Release<T>(T GMFKPONAANG) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x35B9BC0", Offset = "0x35B8FC0", VA = "0x1835B9BC0")]
		public void Prefill<T>(T CFENBMBECBB, int AFHMAFFIFFJ, [Optional] Action<Component> LKNHHBHLKHE) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x35B99E0", Offset = "0x35B8DE0", VA = "0x1835B99E0")]
		public bool Exists<T>(T CFENBMBECBB) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x35B9930", Offset = "0x35B8D30", VA = "0x1835B9930")]
		public void Clear<T>(T CFENBMBECBB) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7796DF0", Offset = "0x77961F0", VA = "0x187796DF0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x35B9A80", Offset = "0x35B8E80", VA = "0x1835B9A80")]
		private LLAJJNPCMIF OOOAFFLEOFB<T>(T CFENBMBECBB) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public void TrackInstantiation(string GCGAEHKGEGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public void EnableStats(bool FPFMNHCPIFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7796F60", Offset = "0x7796360", VA = "0x187796F60")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class LLAJJNPCMIF
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface EHJPFNGONOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BDGMCLMIIPK(bool IMLBMCFLIEF);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string OPDMIMOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int PLHCIGNPKOH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void GLCLOAHEKFN(int BBEJNKBNMID, Action<Component> LKNHHBHLKHE);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component OCHIEBOHGDJ(Action<Component> BPDNFEKELGB);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool BHDLIGCHPAN(Component DCDHPNKMBKF);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void KKIOKOIHHPE();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7795FF0", Offset = "0x77953F0", VA = "0x187795FF0")]
	protected void JAFGPEKHHLP(Component GMFKPONAANG, bool IMLBMCFLIEF, bool OBHHHDKPMLL, bool KKAHBNEJDFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7796170", Offset = "0x7795570", VA = "0x187796170")]
	protected void OKBAIMBGOHO(Transform KNFBINGLKJB, bool IMLBMCFLIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	protected LLAJJNPCMIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FKLLEJAEJGN<T> : LLAJJNPCMIF where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T CFENBMBECBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool LHGCGMAFHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool OBHHHDKPMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> JBICMFJPJJC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string OPDMIMOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x43CF7C0", Offset = "0x43CEBC0", VA = "0x1843CF7C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int PLHCIGNPKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x43CF270", Offset = "0x43CE670", VA = "0x1843CF270", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x43CFA70", Offset = "0x43CEE70", VA = "0x1843CFA70")]
	public FKLLEJAEJGN(T CFENBMBECBB, ObjectPool LHGCGMAFHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x43CF2C0", Offset = "0x43CE6C0", VA = "0x1843CF2C0", Slot = "6")]
	public override void GLCLOAHEKFN(int BBEJNKBNMID, Action<Component> BPDNFEKELGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x43CF7E0", Offset = "0x43CEBE0", VA = "0x1843CF7E0", Slot = "7")]
	public override Component OCHIEBOHGDJ(Action<Component> BPDNFEKELGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x43CF0C0", Offset = "0x43CE4C0", VA = "0x1843CF0C0", Slot = "8")]
	public override bool BHDLIGCHPAN(Component DCDHPNKMBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x43CF5B0", Offset = "0x43CE9B0", VA = "0x1843CF5B0", Slot = "9")]
	public override void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x43CF3F0", Offset = "0x43CE7F0", VA = "0x1843CF3F0")]
	private T JGNHOEBGMHG()
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
		public interface FNGGHELOGFL
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject JAFEDBEGIHN
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
		[Cpp2IlInjected.Address(RVA = "0x7796A70", Offset = "0x7795E70", VA = "0x187796A70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7796D60", Offset = "0x7796160", VA = "0x187796D60")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool NHILJKJCKFJ;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject GEJHFIAODAN;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool IMFIEPMCPDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7797170", Offset = "0x7796570", VA = "0x187797170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x77970B0", Offset = "0x77964B0", VA = "0x1877970B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7795530", Offset = "0x7794930", VA = "0x187795530")]
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
		public LLAJJNPCMIF PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NCOMJHLFNCK
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BJFLPKLPIAA(PooledParticle.BCIBCFCNCFE AJKIFLFMGBI);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum NMMGIPEKGKG
		{
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum BCIBCFCNCFE
		{
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public interface LMPDHMFDHGL
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool KEKPPOPBDNK
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 CKAGNBBBPKD
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera JJPEBOBNDFC
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class ColorConfiguration
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x653E080", Offset = "0x653D480", VA = "0x18653E080")]
			public ColorConfiguration(ParticleSystem PGDKGNNBIJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7795250", Offset = "0x7794650", VA = "0x187795250")]
			public void KEBKKELILPK(Color NHCBHMJDLHA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class DJEOAKENKBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public DJEOAKENKBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7795440", Offset = "0x7794840", VA = "0x187795440")]
			internal void OHEBODHKKBB(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class NMNCAPKFHGO : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private FBLKJCIOKGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private LMPDHMFDHGL <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
			[DebuggerHidden]
			public NMNCAPKFHGO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x77963F0", Offset = "0x77957F0", VA = "0x1877963F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7796A20", Offset = "0x7795E20", VA = "0x187796A20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class PMFNCFKMKOA : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private FBLKJCIOKGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
			[DebuggerHidden]
			public PMFNCFKMKOA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7796FF0", Offset = "0x77963F0", VA = "0x187796FF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7797060", Offset = "0x7796460", VA = "0x187797060", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static bool OptimizeReleaseMonitoring;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> IMNDGMOMBCL;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Lazy<NCOMJHLFNCK> FGPHCMFEMDC;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static List<PooledParticle> BKOHDHIAGGJ;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static HPLGDNGCOKN BGJGAEILCAN;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float GGLBNBFGNFK = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static bool JGEPLKJHALF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected int DNAMBBLNOBO;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private BCIBCFCNCFE category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float? FFILBGBIKCF;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private ParticleSystem.MinMaxGradient[] MDJHPGMEDCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool PCFDMJMLHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private float OCJECCNHADJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private float ADLENJLLFFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Transform HEFIKJLHCJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Vector3 GGCOPMBIFGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Vector3 NKPGEGEAODG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private NMMGIPEKGKG JNOKBNLCPFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private HPLGDNGCOKN GCLLNJKHBPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		protected bool KNNNEFKADLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Transform JFBBGIKFOBI;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> GPCKJCFJNPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x779B4D0", Offset = "0x779A8D0", VA = "0x18779B4D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public BCIBCFCNCFE IDEKKKHFADG
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9728C0", Offset = "0x971CC0", VA = "0x1809728C0")]
			get
			{
				return default(BCIBCFCNCFE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int JFPFHCEAJIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x94D480", Offset = "0x94C880", VA = "0x18094D480")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool COJHKELOEJN
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x779B200", Offset = "0x779A600", VA = "0x18779B200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int GEECGIFNECK
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x779B380", Offset = "0x779A780", VA = "0x18779B380")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool OBBMHLNHJIO
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7799010", Offset = "0x7798410", VA = "0x187799010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem HPFNMFOAKML
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x94B9E0", Offset = "0x94ADE0", VA = "0x18094B9E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x94B7E0", Offset = "0x94ABE0", VA = "0x18094B7E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] CAMHMBLOAAD
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x94DBC0", Offset = "0x94CFC0", VA = "0x18094DBC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x94D470", Offset = "0x94C870", VA = "0x18094D470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] JPMCCPNOMEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x94BDD0", Offset = "0x94B1D0", VA = "0x18094BDD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x94FAD0", Offset = "0x94EED0", VA = "0x18094FAD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private NMMGIPEKGKG JCDGCPFAIAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x955650", Offset = "0x954A50", VA = "0x180955650")]
			get
			{
				return default(NMMGIPEKGKG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7799470", Offset = "0x7798870", VA = "0x187799470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Transform EJNLPEDOMDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x779B520", Offset = "0x779A920", VA = "0x18779B520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NAJDIBCNKIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x779B160", Offset = "0x779A560", VA = "0x18779B160")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x779B570", Offset = "0x779A970", VA = "0x18779B570")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x779AB70", Offset = "0x7799F70", VA = "0x18779AB70")]
		public static PooledParticle TryPlayPrefab(PooledParticle CFENBMBECBB, Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x779AC90", Offset = "0x779A090", VA = "0x18779AC90")]
		public static PooledParticle TryPlayPrefab(PooledParticle CFENBMBECBB, Vector3 NDADPNJPMFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x779A160", Offset = "0x7799560", VA = "0x18779A160")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x77983B0", Offset = "0x77977B0", VA = "0x1877983B0")]
		private void CMNCPHDNAPN(bool BDDPPMGPFHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7798B60", Offset = "0x7797F60", VA = "0x187798B60")]
		[IteratorStateMachine(typeof(NMNCAPKFHGO))]
		private static IEnumerator<FBLKJCIOKGP> HHIMDODJEPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x77987F0", Offset = "0x7797BF0", VA = "0x1877987F0")]
		private static void GHMNFIMOJFJ(Stopwatch ACNLNBKGHCE, Vector3 CGJHPIKJHEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7798BC0", Offset = "0x7797FC0", VA = "0x187798BC0")]
		private static int JEPMKODGPKB(PooledParticle CLHNCHKFPON, PooledParticle KMNANLEEDKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x77982A0", Offset = "0x77976A0", VA = "0x1877982A0")]
		private static int BJFLPKLPIAA(BCIBCFCNCFE AJKIFLFMGBI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7799280", Offset = "0x7798680", VA = "0x187799280")]
		protected void OAKMKNDHCHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7797890", Offset = "0x7796C90", VA = "0x187797890")]
		protected void AMPFMKJAGAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7797EC0", Offset = "0x77972C0", VA = "0x187797EC0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7798CE0", Offset = "0x77980E0", VA = "0x187798CE0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7799490", Offset = "0x7798890", VA = "0x187799490")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7798760", Offset = "0x7797B60", VA = "0x187798760")]
		[IteratorStateMachine(typeof(PMFNCFKMKOA))]
		private IEnumerator<FBLKJCIOKGP> FGAPJBNAGKC(float LKDAAJDJIMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7798140", Offset = "0x7797540", VA = "0x187798140")]
		private void BHDLIGCHPAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x779A8B0", Offset = "0x7799CB0", VA = "0x18779A8B0")]
		public void SetDuration(float LKDAAJDJIMN, bool JOEOBOCCIKL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7799520", Offset = "0x7798920", VA = "0x187799520")]
		public void Play(Transform CCMNNJOPGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7799DD0", Offset = "0x77991D0", VA = "0x187799DD0")]
		public void Play(Transform CCMNNJOPGKE, bool MIFLAKFLNBM, float LDEDFGAOHFI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7799680", Offset = "0x7798A80", VA = "0x187799680")]
		public void Play(Transform CCMNNJOPGKE, Vector3 NKPGEGEAODG, bool MIFLAKFLNBM, float LDEDFGAOHFI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x77997D0", Offset = "0x7798BD0", VA = "0x1877997D0")]
		public void Play(Transform PMNBMMKNEDO, Quaternion MLMNPOCKAAE, bool MIFLAKFLNBM = false, float LDEDFGAOHFI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7799F40", Offset = "0x7799340", VA = "0x187799F40")]
		public void Play(Transform PMNBMMKNEDO, Vector3 NKPGEGEAODG, Quaternion MLMNPOCKAAE, bool MIFLAKFLNBM = false, float LDEDFGAOHFI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7799A70", Offset = "0x7798E70", VA = "0x187799A70")]
		public void Play(Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE, Vector3 PGIPNLMJJCH, bool MIFLAKFLNBM = false, float LDEDFGAOHFI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7799910", Offset = "0x7798D10", VA = "0x187799910")]
		public void Play(Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE, bool MIFLAKFLNBM = false, float LDEDFGAOHFI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7799BF0", Offset = "0x7798FF0", VA = "0x187799BF0")]
		public void Play(bool MIFLAKFLNBM = false, float LDEDFGAOHFI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x779AAD0", Offset = "0x7799ED0", VA = "0x18779AAD0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x779A980", Offset = "0x7799D80", VA = "0x18779A980")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x77985C0", Offset = "0x77979C0", VA = "0x1877985C0")]
		private void EAKMPLMICKC(float LKDAAJDJIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7798480", Offset = "0x7797880", VA = "0x187798480")]
		private void DLJFJLJENIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x779A070", Offset = "0x7799470", VA = "0x18779A070")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x779A2E0", Offset = "0x77996E0", VA = "0x18779A2E0")]
		public void SetColor(Color NHCBHMJDLHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x77991C0", Offset = "0x77985C0", VA = "0x1877991C0")]
		private void NABLGBBIOGA(float? KGDKBIOOEOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7798C70", Offset = "0x7798070", VA = "0x187798C70")]
		private void JJKFAEADLOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7799090", Offset = "0x7798490", VA = "0x187799090")]
		private void MONHIEMOHOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x779B0C0", Offset = "0x779A4C0", VA = "0x18779B0C0")]
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
