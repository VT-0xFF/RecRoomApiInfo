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
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private float minDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float maxDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Header("Impact Particle System")]
		[SerializeField]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Header("Impact Particle Start Size")]
		[SerializeField]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Header("Impact Particle Start Lifetime")]
		[SerializeField]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Header("Spray Particle System")]
		[SerializeField]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Spray Particle Burst Count")]
		[SerializeField]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x87359B0", Offset = "0x87347B0", VA = "0x1887359B0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles BLNABJHHOFA, float KKJGLDBFEMG, Vector3 FLAPAOJCDCM, Quaternion GKEKGHNHKDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8735650", Offset = "0x8734450", VA = "0x188735650")]
		public void SetDamageValue(float KKJGLDBFEMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8735AF0", Offset = "0x87348F0", VA = "0x188735AF0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PJLAGHIMBCA<T> : AIKJELDGMEB<T>, BFMPGGMMDDD, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EKLGJJHIBLC<T> : BFMPGGMMDDD, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OHFIPBNNCME
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NFLEANEKNOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class KBKCNKGMMKF<T> : DLHALDEOAKE<T>, PJLAGHIMBCA<T>, AIKJELDGMEB<T>, BFMPGGMMDDD, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class EIKCGJCFMPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public KBKCNKGMMKF<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public EIKCGJCFMPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4A60ED0", Offset = "0x4A5FCD0", VA = "0x184A60ED0")]
			internal void LHBPIFBKPOF(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x41A1B50", Offset = "0x41A0950", VA = "0x1841A1B50")]
			internal void GOIEMHKCLNL(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private HNDICJJKNNH<T> FMGMJMGNDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool MMKHNMJIGOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T HNKFODIAFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool JAABGCKHGLN;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5566BA0", Offset = "0x55659A0", VA = "0x185566BA0")]
		public KBKCNKGMMKF(HNDICJJKNNH<T> FMGMJMGNDLF, ObjectPool MMKHNMJIGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5566A60", Offset = "0x5565860", VA = "0x185566A60", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class PFCAHKELKLO<T> : EPDLJACCEEM, EKLGJJHIBLC<T>, BFMPGGMMDDD, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class AALAJPKDIEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public PFCAHKELKLO<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public AALAJPKDIEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x518DD90", Offset = "0x518CB90", VA = "0x18518DD90")]
			internal void LHBPIFBKPOF(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x16F7DA0", Offset = "0x16F6BA0", VA = "0x1816F7DA0")]
			internal void GOIEMHKCLNL(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private HNDICJJKNNH<T> FMGMJMGNDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool JAABGCKHGLN;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5BF63C0", Offset = "0x5BF51C0", VA = "0x185BF63C0")]
		public PFCAHKELKLO(HNDICJJKNNH<T> FMGMJMGNDLF, ObjectPool MMKHNMJIGOL, int CBLNNDEMMGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5BF6360", Offset = "0x5BF5160", VA = "0x185BF6360", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FGPELOKAPCA<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NFLEANEKNOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public DLHALDEOAKE<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public HNDICJJKNNH<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public FGPELOKAPCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4F0A2B0", Offset = "0x4F090B0", VA = "0x184F0A2B0")]
		internal void FICPOMDBEPM(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4F0A200", Offset = "0x4F09000", VA = "0x184F0A200")]
		internal void AAHJPGJFJNE(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4F0A260", Offset = "0x4F09060", VA = "0x184F0A260")]
		internal void EMELDCNGCIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<OHFIPBNNCME> NFIONLHJKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private KFHFEMJNKAP DEMBFPALHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool MMKHNMJIGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool JAABGCKHGLN;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x87343F0", Offset = "0x87331F0", VA = "0x1887343F0")]
	private static void LCPNJMPGMHD(Component PGJHFGMMOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8734800", Offset = "0x8733600", VA = "0x188734800")]
	public NFLEANEKNOK(string KCAHPOJKMFB, int LHCAIJEBGIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3E73D60", Offset = "0x3E72B60", VA = "0x183E73D60")]
	public PJLAGHIMBCA<T> HIGNFNKNAEG<T>(AssetReference AONJLKJFBPM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3E74200", Offset = "0x3E73000", VA = "0x183E74200")]
	public EKLGJJHIBLC<T> MCMOIJLPFLD<T>(AssetReference AONJLKJFBPM, int FFKCBONKOOM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3E73E00", Offset = "0x3E72C00", VA = "0x183E73E00")]
	public AIKJELDGMEB<bool> LHCDGKCPPOM<T>(AssetReference AONJLKJFBPM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8734170", Offset = "0x8732F70", VA = "0x188734170", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8734630", Offset = "0x8733430", VA = "0x188734630")]
	private void OIFNPCAHNOO(UnityEngine.Object IJGLJOIJJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8734260", Offset = "0x8733060", VA = "0x188734260")]
	private ObjectPool JEHDDGHKFBB(string KCAHPOJKMFB)
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
		private static GlobalPool IBKIAAFDJAN;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject JGLFIEAEGMI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool MOIOIMEFPHA
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8733970", Offset = "0x8732770", VA = "0x188733970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3D091A0", Offset = "0x3D07FA0", VA = "0x183D091A0")]
		public static void SafeRelease<T>(T ALGAKMGCCLO) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x87338A0", Offset = "0x87326A0", VA = "0x1887338A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8733960", Offset = "0x8732760", VA = "0x188733960")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct NGCONHBHOIG<T> : IDisposable where T : Component
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly T BFIHBNLKKMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private readonly ObjectPool NMIHGIEBNBF;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public T DDHBFJGPDAJ
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xC55370", Offset = "0xC54170", VA = "0x180C55370")]
			internal NGCONHBHOIG(T HGMAIPELJHM, ObjectPool NMIHGIEBNBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x59717E0", Offset = "0x59705E0", VA = "0x1859717E0", Slot = "4")]
			void IDisposable.Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, OINEBDKNMFJ> HMANOPJDGBG;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3EF20C0", Offset = "0x3EF0EC0", VA = "0x183EF20C0")]
		public T Acquire<T>(T BLNABJHHOFA, [Optional] Action<Component> JFCCKAKIEBF) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3EF2040", Offset = "0x3EF0E40", VA = "0x183EF2040")]
		public NGCONHBHOIG<T> AcquirePooledObject<T>(T BLNABJHHOFA, [Optional] Action<Component> JFCCKAKIEBF) where T : Component
		{
			return default(NGCONHBHOIG<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3EF2430", Offset = "0x3EF1230", VA = "0x183EF2430")]
		public bool Release<T>(T ALGAKMGCCLO) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3EF23E0", Offset = "0x3EF11E0", VA = "0x183EF23E0")]
		public void Prefill<T>(T BLNABJHHOFA, int NMDPLIBBHCE, [Optional] Action<Component> CODIGJJMKEJ) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3EF2200", Offset = "0x3EF1000", VA = "0x183EF2200")]
		public bool Exists<T>(T BLNABJHHOFA) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3EF2150", Offset = "0x3EF0F50", VA = "0x183EF2150")]
		public void Clear<T>(T BLNABJHHOFA) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8735210", Offset = "0x8734010", VA = "0x188735210")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3EF22A0", Offset = "0x3EF10A0", VA = "0x183EF22A0")]
		private OINEBDKNMFJ GOLMDEOIBNC<T>(T BLNABJHHOFA) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
		public void TrackInstantiation(string PAIPGKCDEIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
		public void EnableStats(bool BBFGMPDBGEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8735380", Offset = "0x8734180", VA = "0x188735380")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class OINEBDKNMFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface MEHGCMEBBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KEHHBNOEGJI(bool HEPPDGLDFNF);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int FMNGJBKIOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void MCMOIJLPFLD(int FFKCBONKOOM, Action<Component> CODIGJJMKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component HIGNFNKNAEG(Action<Component> JFCCKAKIEBF);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool OJNCHOHBCNI(Component AAJIFFABDID);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void FMJEOCFJDAJ();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8734D10", Offset = "0x8733B10", VA = "0x188734D10")]
	protected void FNJCEKGMGCL(Component ALGAKMGCCLO, bool HEPPDGLDFNF, bool EPBFNCLJBJC, bool GHLGPGKBGCB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8734A90", Offset = "0x8733890", VA = "0x188734A90")]
	protected void DNJCFBFECDP(Transform KCFFMNPFCBM, bool HEPPDGLDFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	protected OINEBDKNMFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LGAPCBPAGJC<T> : OINEBDKNMFJ where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private T BLNABJHHOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private ObjectPool NOIMCAEIMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool EPBFNCLJBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Queue<T> OGONIHGDGJK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5686020", Offset = "0x5684E20", VA = "0x185686020", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int FMNGJBKIOEH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5685720", Offset = "0x5684520", VA = "0x185685720", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5686040", Offset = "0x5684E40", VA = "0x185686040")]
	public LGAPCBPAGJC(T BLNABJHHOFA, ObjectPool NOIMCAEIMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5685D70", Offset = "0x5684B70", VA = "0x185685D70", Slot = "6")]
	public override void MCMOIJLPFLD(int FFKCBONKOOM, Action<Component> JFCCKAKIEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5685B00", Offset = "0x5684900", VA = "0x185685B00", Slot = "7")]
	public override Component HIGNFNKNAEG(Action<Component> JFCCKAKIEBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5685E80", Offset = "0x5684C80", VA = "0x185685E80", Slot = "8")]
	public override bool OJNCHOHBCNI(Component AAJIFFABDID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5685910", Offset = "0x5684710", VA = "0x185685910", Slot = "9")]
	public override void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5685760", Offset = "0x5684560", VA = "0x185685760")]
	private T BELJJILEOPP()
	{
		return null;
	}
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class ObjectPoolPreFill : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct PrefillDataEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Component prefab;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public int numInstances;
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public interface BGJGHHPFAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject LKEPGLHDENI
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8734E90", Offset = "0x8733C90", VA = "0x188734E90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8735180", Offset = "0x8733F80", VA = "0x188735180")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static PersistentGlobalPool IBKIAAFDJAN;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static GameObject JGLFIEAEGMI;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool MOIOIMEFPHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x87354D0", Offset = "0x87342D0", VA = "0x1887354D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8735410", Offset = "0x8734210", VA = "0x188735410")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8733960", Offset = "0x8732760", VA = "0x188733960")]
		public PersistentGlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class PooledObject : MonoBehaviour
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public OINEBDKNMFJ PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DCJKOPJFFEB
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NANIPCHKMLN(PooledParticle.BGHFOLDIOOG IBMBMDODBPF);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private enum AAMOOCGBLMM
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum BGHFOLDIOOG
		{
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public interface BAJBFKMDNAI
		{
			[Cpp2IlInjected.Token(Token = "0x17000014")]
			bool GNDNFAAMDAM
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Vector3 IDEMIBEFIME
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			Camera AKCEOGFGOEF
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class ColorConfiguration
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x72F6730", Offset = "0x72F5530", VA = "0x1872F6730")]
			public ColorConfiguration(ParticleSystem BJMLDFGMKDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x87335F0", Offset = "0x87323F0", VA = "0x1887335F0")]
			public void AHNBALNGMMI(Color BGBIPHDMBPB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class HBNBNDPENHG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public HBNBNDPENHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8733AC0", Offset = "0x87328C0", VA = "0x188733AC0")]
			internal void DEHHLGEPGII(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class HENMMDGEILO : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private PHFDFIIIMCE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private BAJBFKMDNAI <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public HENMMDGEILO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8733AF0", Offset = "0x87328F0", VA = "0x188733AF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8734120", Offset = "0x8732F20", VA = "0x188734120", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class FBPCHMGHCOB : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private PHFDFIIIMCE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public FBPCHMGHCOB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x87337E0", Offset = "0x87325E0", VA = "0x1887337E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8733850", Offset = "0x8732650", VA = "0x188733850", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static bool OptimizeReleaseMonitoring;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> HGJPGAOOAFC;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly Lazy<DCJKOPJFFEB> GHGHBKJJKND;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static List<PooledParticle> BBPBNAEPAIG;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static GMJHELKMAKL MFOBILBLBHL;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const float MODBHKBHLEL = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool LNMCDHCAFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected int PCPPNIFGHFL;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private BGHFOLDIOOG category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float? BKIOBDMLDNB;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private ParticleSystem.MinMaxGradient[] LLKKNFHJGFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private ParticleSystem.MinMaxGradient[] KIAGOEJPELJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private bool GLOHBFNNBBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private float OCDOPJINMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private float GPIPIHAEFNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Transform CGKEILOCDML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 NAJGPCCEFIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Vector3 FBMMHMPHCJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private AAMOOCGBLMM MANIKDNOIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private GMJHELKMAKL DKDLEHKCOFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		protected bool KFMPOPPJLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private Transform AAOBOGCCCPN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> OBGGOCEGOID
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8739850", Offset = "0x8738650", VA = "0x188739850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public BGHFOLDIOOG FBGMLHCEHDA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xABCF70", Offset = "0xABBD70", VA = "0x180ABCF70")]
			get
			{
				return default(BGHFOLDIOOG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int OHBBOMHNCHC
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool PBCFLHHCNIH
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8739590", Offset = "0x8738390", VA = "0x188739590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int PCIOAPLKHOO
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8739700", Offset = "0x8738500", VA = "0x188739700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool IKGNLHOENHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8737790", Offset = "0x8736590", VA = "0x188737790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem HCGMFBPLNHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] GJFJCNLEPJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] IFNEPPNIGMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private AAMOOCGBLMM IEPOMICEGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xF3D3D0", Offset = "0xF3C1D0", VA = "0x180F3D3D0")]
			get
			{
				return default(AAMOOCGBLMM);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8736880", Offset = "0x8735680", VA = "0x188736880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Transform DNNOOFELIOA
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x87398A0", Offset = "0x87386A0", VA = "0x1887398A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action IGBDOCDBJGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x87394F0", Offset = "0x87382F0", VA = "0x1887394F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x87398F0", Offset = "0x87386F0", VA = "0x1887398F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8738F30", Offset = "0x8737D30", VA = "0x188738F30")]
		public static PooledParticle TryPlayPrefab(PooledParticle BLNABJHHOFA, Vector3 FLAPAOJCDCM, Quaternion GKEKGHNHKDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8739050", Offset = "0x8737E50", VA = "0x188739050")]
		public static PooledParticle TryPlayPrefab(PooledParticle BLNABJHHOFA, Vector3 FLAPAOJCDCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8738640", Offset = "0x8737440", VA = "0x188738640")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x87378A0", Offset = "0x87366A0", VA = "0x1887378A0")]
		private void PGJIFCAPIOF(bool BNIEEGBIIHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8736680", Offset = "0x8735480", VA = "0x188736680")]
		[IteratorStateMachine(typeof(HENMMDGEILO))]
		private static IEnumerator<PHFDFIIIMCE> FMOIANNKKPO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8736B60", Offset = "0x8735960", VA = "0x188736B60")]
		private static void LPBMKNEMLJA(Stopwatch CIEPDNOLKJK, Vector3 GGKDHDMEJBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8736AB0", Offset = "0x87358B0", VA = "0x188736AB0")]
		private static int LGODLOLLBPP(PooledParticle CHAEOFDBIAH, PooledParticle EBEGEKLHGJL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8737290", Offset = "0x8736090", VA = "0x188737290")]
		private static int NANIPCHKMLN(BGHFOLDIOOG IBMBMDODBPF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x87373A0", Offset = "0x87361A0", VA = "0x1887373A0")]
		protected void NJCIIEIMNGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8735F70", Offset = "0x8734D70", VA = "0x188735F70")]
		protected void EAPJIIKLFNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8735BD0", Offset = "0x87349D0", VA = "0x188735BD0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8736ED0", Offset = "0x8735CD0", VA = "0x188736ED0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8737810", Offset = "0x8736610", VA = "0x188737810")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8737200", Offset = "0x8736000", VA = "0x188737200")]
		[IteratorStateMachine(typeof(FBPCHMGHCOB))]
		private IEnumerator<PHFDFIIIMCE> MDALGMCHHBN(float DFOOIFEDPMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8737590", Offset = "0x8736390", VA = "0x188737590")]
		private void OJNCHOHBCNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8738C70", Offset = "0x8737A70", VA = "0x188738C70")]
		public void SetDuration(float DFOOIFEDPMI, bool KIDPCHEGPGJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8737970", Offset = "0x8736770", VA = "0x188737970")]
		public void Play(Transform NBODAIMLBCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8738210", Offset = "0x8737010", VA = "0x188738210")]
		public void Play(Transform NBODAIMLBCG, bool EHDFDIHKEMF, float JHNJMNIEGKF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8737AC0", Offset = "0x87368C0", VA = "0x188737AC0")]
		public void Play(Transform NBODAIMLBCG, Vector3 FBMMHMPHCJL, bool EHDFDIHKEMF, float JHNJMNIEGKF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8737C10", Offset = "0x8736A10", VA = "0x188737C10")]
		public void Play(Transform NAPFOBLDEIE, Quaternion GKEKGHNHKDP, bool EHDFDIHKEMF = false, float JHNJMNIEGKF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8738380", Offset = "0x8737180", VA = "0x188738380")]
		public void Play(Transform NAPFOBLDEIE, Vector3 FBMMHMPHCJL, Quaternion GKEKGHNHKDP, bool EHDFDIHKEMF = false, float JHNJMNIEGKF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8737EB0", Offset = "0x8736CB0", VA = "0x188737EB0")]
		public void Play(Vector3 FLAPAOJCDCM, Quaternion GKEKGHNHKDP, Vector3 ILLMOMMKCAB, bool EHDFDIHKEMF = false, float JHNJMNIEGKF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8737D50", Offset = "0x8736B50", VA = "0x188737D50")]
		public void Play(Vector3 FLAPAOJCDCM, Quaternion GKEKGHNHKDP, bool EHDFDIHKEMF = false, float JHNJMNIEGKF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8738030", Offset = "0x8736E30", VA = "0x188738030")]
		public void Play(bool EHDFDIHKEMF = false, float JHNJMNIEGKF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8738E90", Offset = "0x8737C90", VA = "0x188738E90")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8738D40", Offset = "0x8737B40", VA = "0x188738D40")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x87366E0", Offset = "0x87354E0", VA = "0x1887366E0")]
		private void GEILIHAHCIM(float DFOOIFEDPMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x87368A0", Offset = "0x87356A0", VA = "0x1887368A0")]
		private void IICMIAPBKDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x87384B0", Offset = "0x87372B0", VA = "0x1887384B0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x87387C0", Offset = "0x87375C0", VA = "0x1887387C0")]
		public void SetColor(Color BGBIPHDMBPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8736550", Offset = "0x8735350", VA = "0x188736550")]
		private void EDMBPEHNPME(float? GJEDFMHCPFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8736610", Offset = "0x8735410", VA = "0x188736610")]
		private void FBIHPLOBODA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8735E40", Offset = "0x8734C40", VA = "0x188735E40")]
		private void DOOICPEGHBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8739460", Offset = "0x8738260", VA = "0x188739460")]
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
