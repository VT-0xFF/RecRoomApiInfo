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
		[Cpp2IlInjected.Address(RVA = "0x7839AE0", Offset = "0x78380E0", VA = "0x187839AE0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles CFENBMBECBB, float AOGBFMICMMM, Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7839780", Offset = "0x7837D80", VA = "0x187839780")]
		public void SetDamageValue(float AOGBFMICMMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7839C20", Offset = "0x7838220", VA = "0x187839C20")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public HAMGMEICDOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x45EB070", Offset = "0x45E9670", VA = "0x1845EB070")]
			internal void MMFIKBIHOOK(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3443BB0", Offset = "0x34421B0", VA = "0x183443BB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4625390", Offset = "0x4623990", VA = "0x184625390")]
		public HBPFHPJGKFD(EBHOPDBMNPK<T> NGHJKODNPLB, ObjectPool JFNIOBJOEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4625220", Offset = "0x4623820", VA = "0x184625220", Slot = "27")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public FMOBGEJIABE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x4436D40", Offset = "0x4435340", VA = "0x184436D40")]
			internal void MMFIKBIHOOK(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x1207D70", Offset = "0x1206370", VA = "0x181207D70")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E9E4B0", Offset = "0x4E9CAB0", VA = "0x184E9E4B0")]
		public NHLCIMJDOOG(EBHOPDBMNPK<T> NGHJKODNPLB, ObjectPool JFNIOBJOEJO, int PEHMKNBLLOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E450", Offset = "0x4E9CA50", VA = "0x184E9E450", Slot = "19")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public EKPMHPEEKOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x406D9E0", Offset = "0x406BFE0", VA = "0x18406D9E0")]
		internal void KMIAKMNBGGG(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x406D930", Offset = "0x406BF30", VA = "0x18406D930")]
		internal void ANPAPOGGFDC(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x406D990", Offset = "0x406BF90", VA = "0x18406D990")]
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
	[Cpp2IlInjected.Address(RVA = "0x7837EF0", Offset = "0x78364F0", VA = "0x187837EF0")]
	private static void PAKMMOGIOJL(Component MEFMJJOMDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x78381D0", Offset = "0x78367D0", VA = "0x1878381D0")]
	public JOLJKKFGKEN(string BPDGMLOBIKL, int FDIHOEFFEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3473C00", Offset = "0x3472200", VA = "0x183473C00")]
	public PFADGFBHMAK<T> OCHIEBOHGDJ<T>(AssetReference LLFKBAMNPDC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3473B20", Offset = "0x3472120", VA = "0x183473B20")]
	public BCMNJBBOGDC<T> GLCLOAHEKFN<T>(AssetReference LLFKBAMNPDC, int BBEJNKBNMID) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3473700", Offset = "0x3471D00", VA = "0x183473700")]
	public NEEPBAPEEOL<bool> GAJJJBGADKG<T>(AssetReference LLFKBAMNPDC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7837B20", Offset = "0x7836120", VA = "0x187837B20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7837DA0", Offset = "0x78363A0", VA = "0x187837DA0")]
	private void IGGEEKNJNIM(UnityEngine.Object NCAHJLMHIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7837C10", Offset = "0x7836210", VA = "0x187837C10")]
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
			[Cpp2IlInjected.Address(RVA = "0x78379B0", Offset = "0x7835FB0", VA = "0x1878379B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x33E40C0", Offset = "0x33E26C0", VA = "0x1833E40C0")]
		public static void SafeRelease<T>(T GMFKPONAANG) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x78378E0", Offset = "0x7835EE0", VA = "0x1878378E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x78379A0", Offset = "0x7835FA0", VA = "0x1878379A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x35FCEC0", Offset = "0x35FB4C0", VA = "0x1835FCEC0")]
		public T Acquire<T>(T CFENBMBECBB, [Optional] Action<Component> BPDNFEKELGB) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x35FD280", Offset = "0x35FB880", VA = "0x1835FD280")]
		public bool Release<T>(T GMFKPONAANG) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x35FD210", Offset = "0x35FB810", VA = "0x1835FD210")]
		public void Prefill<T>(T CFENBMBECBB, int AFHMAFFIFFJ, [Optional] Action<Component> LKNHHBHLKHE) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x35FD030", Offset = "0x35FB630", VA = "0x1835FD030")]
		public bool Exists<T>(T CFENBMBECBB) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x35FCF80", Offset = "0x35FB580", VA = "0x1835FCF80")]
		public void Clear<T>(T CFENBMBECBB) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7839260", Offset = "0x7837860", VA = "0x187839260")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x35FD0D0", Offset = "0x35FB6D0", VA = "0x1835FD0D0")]
		private LLAJJNPCMIF OOOAFFLEOFB<T>(T CFENBMBECBB) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
		public void TrackInstantiation(string GCGAEHKGEGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
		public void EnableStats(bool FPFMNHCPIFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x78393D0", Offset = "0x78379D0", VA = "0x1878393D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7838460", Offset = "0x7836A60", VA = "0x187838460")]
	protected void JAFGPEKHHLP(Component GMFKPONAANG, bool IMLBMCFLIEF, bool OBHHHDKPMLL, bool KKAHBNEJDFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x78385E0", Offset = "0x7836BE0", VA = "0x1878385E0")]
	protected void OKBAIMBGOHO(Transform KNFBINGLKJB, bool IMLBMCFLIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x44294E0", Offset = "0x4427AE0", VA = "0x1844294E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int PLHCIGNPKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4428F90", Offset = "0x4427590", VA = "0x184428F90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4429790", Offset = "0x4427D90", VA = "0x184429790")]
	public FKLLEJAEJGN(T CFENBMBECBB, ObjectPool LHGCGMAFHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4428FE0", Offset = "0x44275E0", VA = "0x184428FE0", Slot = "6")]
	public override void GLCLOAHEKFN(int BBEJNKBNMID, Action<Component> BPDNFEKELGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4429500", Offset = "0x4427B00", VA = "0x184429500", Slot = "7")]
	public override Component OCHIEBOHGDJ(Action<Component> BPDNFEKELGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4428DE0", Offset = "0x44273E0", VA = "0x184428DE0", Slot = "8")]
	public override bool BHDLIGCHPAN(Component DCDHPNKMBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x44292D0", Offset = "0x44278D0", VA = "0x1844292D0", Slot = "9")]
	public override void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4429110", Offset = "0x4427710", VA = "0x184429110")]
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
		[Cpp2IlInjected.Address(RVA = "0x7838EE0", Offset = "0x78374E0", VA = "0x187838EE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x78391D0", Offset = "0x78377D0", VA = "0x1878391D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x78395E0", Offset = "0x7837BE0", VA = "0x1878395E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7839520", Offset = "0x7837B20", VA = "0x187839520")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x78379A0", Offset = "0x7835FA0", VA = "0x1878379A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x951A50", Offset = "0x950050", VA = "0x180951A50")]
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
			[Cpp2IlInjected.Address(RVA = "0x65A3250", Offset = "0x65A1850", VA = "0x1865A3250")]
			public ColorConfiguration(ParticleSystem PGDKGNNBIJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x78376C0", Offset = "0x7835CC0", VA = "0x1878376C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public DJEOAKENKBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x78378B0", Offset = "0x7835EB0", VA = "0x1878378B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
			[DebuggerHidden]
			public NMNCAPKFHGO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x7838860", Offset = "0x7836E60", VA = "0x187838860", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7838E90", Offset = "0x7837490", VA = "0x187838E90", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
			[DebuggerHidden]
			public PMFNCFKMKOA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7839460", Offset = "0x7837A60", VA = "0x187839460", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x78394D0", Offset = "0x7837AD0", VA = "0x1878394D0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x783D940", Offset = "0x783BF40", VA = "0x18783D940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public BCIBCFCNCFE IDEKKKHFADG
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x979920", Offset = "0x977F20", VA = "0x180979920")]
			get
			{
				return default(BCIBCFCNCFE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int JFPFHCEAJIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x954480", Offset = "0x952A80", VA = "0x180954480")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool COJHKELOEJN
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x783D670", Offset = "0x783BC70", VA = "0x18783D670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int GEECGIFNECK
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x783D7F0", Offset = "0x783BDF0", VA = "0x18783D7F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool OBBMHLNHJIO
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x783B480", Offset = "0x7839A80", VA = "0x18783B480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem HPFNMFOAKML
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9529E0", Offset = "0x950FE0", VA = "0x1809529E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9527E0", Offset = "0x950DE0", VA = "0x1809527E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] CAMHMBLOAAD
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x954470", Offset = "0x952A70", VA = "0x180954470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] JPMCCPNOMEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x956AD0", Offset = "0x9550D0", VA = "0x180956AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private NMMGIPEKGKG JCDGCPFAIAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x95C650", Offset = "0x95AC50", VA = "0x18095C650")]
			get
			{
				return default(NMMGIPEKGKG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x783B8E0", Offset = "0x7839EE0", VA = "0x18783B8E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Transform EJNLPEDOMDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x783D990", Offset = "0x783BF90", VA = "0x18783D990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NAJDIBCNKIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x783D5D0", Offset = "0x783BBD0", VA = "0x18783D5D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x783D9E0", Offset = "0x783BFE0", VA = "0x18783D9E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x783CFE0", Offset = "0x783B5E0", VA = "0x18783CFE0")]
		public static PooledParticle TryPlayPrefab(PooledParticle CFENBMBECBB, Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x783D100", Offset = "0x783B700", VA = "0x18783D100")]
		public static PooledParticle TryPlayPrefab(PooledParticle CFENBMBECBB, Vector3 NDADPNJPMFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x783C5D0", Offset = "0x783ABD0", VA = "0x18783C5D0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x783A820", Offset = "0x7838E20", VA = "0x18783A820")]
		private void CMNCPHDNAPN(bool BDDPPMGPFHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x783AFD0", Offset = "0x78395D0", VA = "0x18783AFD0")]
		[IteratorStateMachine(typeof(NMNCAPKFHGO))]
		private static IEnumerator<FBLKJCIOKGP> HHIMDODJEPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x783AC60", Offset = "0x7839260", VA = "0x18783AC60")]
		private static void GHMNFIMOJFJ(Stopwatch ACNLNBKGHCE, Vector3 CGJHPIKJHEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x783B030", Offset = "0x7839630", VA = "0x18783B030")]
		private static int JEPMKODGPKB(PooledParticle CLHNCHKFPON, PooledParticle KMNANLEEDKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x783A710", Offset = "0x7838D10", VA = "0x18783A710")]
		private static int BJFLPKLPIAA(BCIBCFCNCFE AJKIFLFMGBI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x783B6F0", Offset = "0x7839CF0", VA = "0x18783B6F0")]
		protected void OAKMKNDHCHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7839D00", Offset = "0x7838300", VA = "0x187839D00")]
		protected void AMPFMKJAGAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x783A330", Offset = "0x7838930", VA = "0x18783A330", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x783B150", Offset = "0x7839750", VA = "0x18783B150")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x783B900", Offset = "0x7839F00", VA = "0x18783B900")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x783ABD0", Offset = "0x78391D0", VA = "0x18783ABD0")]
		[IteratorStateMachine(typeof(PMFNCFKMKOA))]
		private IEnumerator<FBLKJCIOKGP> FGAPJBNAGKC(float LKDAAJDJIMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x783A5B0", Offset = "0x7838BB0", VA = "0x18783A5B0")]
		private void BHDLIGCHPAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x783CD20", Offset = "0x783B320", VA = "0x18783CD20")]
		public void SetDuration(float LKDAAJDJIMN, bool JOEOBOCCIKL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x783B990", Offset = "0x7839F90", VA = "0x18783B990")]
		public void Play(Transform CCMNNJOPGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x783C240", Offset = "0x783A840", VA = "0x18783C240")]
		public void Play(Transform CCMNNJOPGKE, bool MIFLAKFLNBM, float LDEDFGAOHFI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x783BAF0", Offset = "0x783A0F0", VA = "0x18783BAF0")]
		public void Play(Transform CCMNNJOPGKE, Vector3 NKPGEGEAODG, bool MIFLAKFLNBM, float LDEDFGAOHFI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x783BC40", Offset = "0x783A240", VA = "0x18783BC40")]
		public void Play(Transform PMNBMMKNEDO, Quaternion MLMNPOCKAAE, bool MIFLAKFLNBM = false, float LDEDFGAOHFI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x783C3B0", Offset = "0x783A9B0", VA = "0x18783C3B0")]
		public void Play(Transform PMNBMMKNEDO, Vector3 NKPGEGEAODG, Quaternion MLMNPOCKAAE, bool MIFLAKFLNBM = false, float LDEDFGAOHFI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x783BEE0", Offset = "0x783A4E0", VA = "0x18783BEE0")]
		public void Play(Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE, Vector3 PGIPNLMJJCH, bool MIFLAKFLNBM = false, float LDEDFGAOHFI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x783BD80", Offset = "0x783A380", VA = "0x18783BD80")]
		public void Play(Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE, bool MIFLAKFLNBM = false, float LDEDFGAOHFI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x783C060", Offset = "0x783A660", VA = "0x18783C060")]
		public void Play(bool MIFLAKFLNBM = false, float LDEDFGAOHFI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x783CF40", Offset = "0x783B540", VA = "0x18783CF40")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x783CDF0", Offset = "0x783B3F0", VA = "0x18783CDF0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x783AA30", Offset = "0x7839030", VA = "0x18783AA30")]
		private void EAKMPLMICKC(float LKDAAJDJIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x783A8F0", Offset = "0x7838EF0", VA = "0x18783A8F0")]
		private void DLJFJLJENIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x783C4E0", Offset = "0x783AAE0", VA = "0x18783C4E0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x783C750", Offset = "0x783AD50", VA = "0x18783C750")]
		public void SetColor(Color NHCBHMJDLHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x783B630", Offset = "0x7839C30", VA = "0x18783B630")]
		private void NABLGBBIOGA(float? KGDKBIOOEOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x783B0E0", Offset = "0x78396E0", VA = "0x18783B0E0")]
		private void JJKFAEADLOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x783B500", Offset = "0x7839B00", VA = "0x18783B500")]
		private void MONHIEMOHOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x783D530", Offset = "0x783BB30", VA = "0x18783D530")]
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
